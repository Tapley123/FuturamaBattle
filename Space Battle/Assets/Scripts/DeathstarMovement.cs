using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathstarMovement : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 2, 2);
    public bool alive = true;
    public float health = 100f;
    [SerializeField]private Animator stateMachineAnimator;

    private void Start()
    {
        stateMachineAnimator = GameObject.Find("Planet Express 1").GetComponent<Animator>();
    }

    void Update()
    {
        this.transform.Rotate(rotationSpeed);

        if (health <= 0)
        {
            alive = false;
        }

        if(!alive)
        {
            transform.position = new Vector3(10000, 10000, 10000);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            health -= 1;
        }
    }
}
