using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoid : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;
    public Vector3 force = Vector3.zero;
    public Vector3 acceleration = Vector3.zero;

    public float mass = 1.0f;
    
    public float maxSpeed = 5f;
    public float maxForce = 10f;

    public float speed = 0;

    public bool seekEnabled = false;
    public Vector3 target;
    public Transform targetTransform; 

    public bool arriveEnabled = false;
    public float slowingDistance = 10f;

    [Range(0.0f, 10f)]
    public float banking = 0.1f;

    public bool playerSteeringEnabled = false;
    public float playerForce = 100;

    public float damping = 1f;

    public Vector3 PlayerSteering()
    {
        Vector3 f = Vector3.zero;

        f += Input.GetAxis("Vertical") * transform.forward * playerForce;
        //f += Input.GetAxis("CVertical") * transform.forward * playerForce;   ///controller input

        Vector3 projectedRight = transform.right;
        projectedRight.y = 0; //Freeze the y axis so the banking doesnt interfear with turning
        projectedRight.Normalize();
        f += Input.GetAxis("Horizontal") * transform.right * playerForce * 0.2f;
        //f += Input.GetAxis("CHorizontal") * transform.right * playerForce * 0.2f;    ///controller input

        return f;
    }

    void Start()
    {
        
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.green; //target is green
        Gizmos.DrawSphere(target, 0.1f);

        Gizmos.color = Color.blue; //force line is blue
        Gizmos.DrawLine(transform.position, transform.position + force);

        Gizmos.color = Color.yellow; // velocity is yellow
        Gizmos.DrawLine(transform.position, transform.position + velocity);

        Gizmos.color = Color.magenta; // Slowing speed
        Gizmos.DrawWireSphere(target, slowingDistance);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (targetTransform != null)
        {
            target = targetTransform.position;
        }
        force = CalculateForce();
        acceleration = force / mass;
        velocity += acceleration * Time.deltaTime;

        transform.position += velocity * Time.deltaTime;
        speed = velocity.magnitude;
        if (speed > 0)
        {
            Vector3 tempUp = Vector3.Lerp(transform.up, Vector3.up + (acceleration * banking), Time.deltaTime * 0.3f);
            transform.LookAt(transform.position + velocity, tempUp);
            //transform.forward = velocity;
            velocity -= (damping * velocity * Time.deltaTime);

        }

    }

    ////////////////////////////////////////////////////////////////////IMPORTANT/////////////////////////////////////////////////////////////////////
    public Vector3 Seek(Vector3 target)
    {
        Vector3 toTarget = target - transform.position;
        Vector3 desired = toTarget.normalized * maxSpeed;

        return desired - velocity;
    }

    Vector3 Arrive(Vector3 target)
    {
        Vector3 toTarget = target - transform.position;
        float dist = toTarget.magnitude;

        float ramped = (dist / slowingDistance) * maxSpeed;
        float clamped = Mathf.Min(ramped, maxSpeed);
        Vector3 desired = (toTarget / dist) * clamped;

        return desired - velocity;
    }

    public Vector3 CalculateForce()
    {
        Vector3 force = Vector3.zero;
        if (seekEnabled)
        {
            force += Seek(target);
        }

        if (arriveEnabled)
        {
            force += Arrive(target);
        }

        if(playerSteeringEnabled)
        {
            force += PlayerSteering();
        }

        return force;
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
