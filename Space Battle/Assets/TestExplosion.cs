using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestExplosion : MonoBehaviour
{
    public GameObject explosion;

    void Start()
    {
        
    }

    void Update()
    {
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
