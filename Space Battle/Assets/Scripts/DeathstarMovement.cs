using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathstarMovement : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 2, 2);
    public bool alive = true;
    public float health = 100f;
    [SerializeField]private Animator stateMachineAnimator;
    public GameObject explosion;
    private bool exploded = false;

    public string dName; 

    private void Start()
    {
        stateMachineAnimator = GameObject.Find("Planet Express 1").GetComponent<Animator>();

        dName = this.gameObject.name;
    }

    void Update()
    {
        this.transform.Rotate(rotationSpeed);

        if (health <= 0)
        {
            alive = false;
        }

        if(health <= 1 && !exploded)
        {
            GameObject exp = Instantiate(explosion, transform.position, transform.rotation);
            exp.transform.parent = GameObject.Find("Explosions").transform;
            exploded = true;
            //Destroy(gameObject);
        }
            

        if (!alive)
        {
            transform.position = new Vector3(10000, 10000, 10000);
            //this.gameObject.SetActive(false);
            stateMachineAnimator.SetBool("CurrentTargetDead", true);
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
