using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathstarMovement : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 2, 2);

    void Update()
    {
        this.transform.Rotate(rotationSpeed);
    }
}
