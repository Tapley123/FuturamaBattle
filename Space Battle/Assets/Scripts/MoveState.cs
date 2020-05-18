using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : MonoBehaviour
{
    private Animator anim;
    public float xVal = 37f;
    void Start()
    {
        anim = GameObject.Find("Planet Express 1").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= xVal)
        {
            anim.SetTrigger("BankDone");
        }
    }
}
