using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathstarMovement : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 2, 2);
    public bool alive = true;

    void Update()
    {
        this.transform.Rotate(rotationSpeed);

        if(!alive)
        {
            transform.position = new Vector3(10000, 10000, 10000);
        }
    }
}
