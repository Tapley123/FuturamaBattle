using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XboxRemoteInput : MonoBehaviour
{
    private Transform myT;
    private float rotationSpeed = 2f;

    void Start()
    {
        myT = GetComponent<Transform>();
    }

    
    void Update()
    {
        ////////////////////////////////////////////////////////Rotation With Right Joystick////////////////////////////////////////////////////////////
        float horizontalRotation = Input.GetAxis("CMouse X");
        float verticalRotation = Input.GetAxis("CMouse Y");
        Vector3 lookhereX = new Vector3(verticalRotation, horizontalRotation, 0);
        myT.Rotate(lookhereX);

        //Debug.Log(RT);
        float RT = Input.GetAxis("RT");
        
    }
}
