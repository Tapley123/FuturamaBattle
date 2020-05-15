using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadShip : MonoBehaviour
{
    public List<GameObject> ships = new List<GameObject>();
    public float lerpTime = 0.2f;
    public float moveSpeed = 3f, rotationSpeed = 1f;

    public float row = 5f, line = 5f;

    public GameObject target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move lead ship to target
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * moveSpeed);
        transform.LookAt(target.transform);

        //mirror lead ships rotation
        for (int i = 0; i <= ships.Count - 1; i++)
        {
            ships[i].transform.rotation = transform.rotation;
        }

        

        //mobship
        ships[0].transform.position = Vector3.Lerp(ships[0].transform.position, new Vector3(transform.position.x - row, transform.position.y, transform.position.z + line), Time.time * lerpTime);
        ships[1].transform.position = Vector3.Lerp(ships[1].transform.position, new Vector3(transform.position.x - row, transform.position.y, transform.position.z - line), Time.time * lerpTime);


        target.transform.position = target.transform.position + Vector3.forward;
    }
}
