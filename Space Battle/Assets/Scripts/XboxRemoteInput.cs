using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XboxRemoteInput : MonoBehaviour
{
    private Transform myT;
    private Rigidbody myRb;
    private float rotationSpeed = 2f;
    public float speed = 10f;

    void Start()
    {
        myT = GetComponent<Transform>();
        myRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        ////////////////////////////////////////////////////////Rotation With Right Joystick////////////////////////////////////////////////////////////
        float horizontalRotation = Input.GetAxis("CMouse X");
        float verticalRotation = Input.GetAxis("CMouse Y");
        Vector3 lookhereX = new Vector3(verticalRotation, horizontalRotation, 0);
        myT.Rotate(lookhereX);

        
        float RT = Input.GetAxis("RT");
        float LT = Input.GetAxis("LT");
        //Debug.Log(RT);

        //myRb.velocity = new Vector3 (myRb.velocity.x, myRb.velocity.y, myRb.velocity.x + RT * speed);
        myT.position += myT.forward * + RT * speed;
        myT.position += (myT.forward * -1) * + LT * speed;
    }
}
