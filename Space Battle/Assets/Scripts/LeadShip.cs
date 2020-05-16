using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeadShip : MonoBehaviour
{
    private List<GameObject> ships = new List<GameObject>();
    private List<Vector3> positions = new List<Vector3>();

    private float lerpTime = 0.2f;
    public float moveSpeed = 3f, rotationSpeed = 1f;
    private float row = 20f, line = 20f;

    public GameObject target;

    private bool moveToFormation, chaseTarget = false;

    void Start()
    {
        StartCoroutine(Formation(5));

        ships.Add(GameObject.Find("Mob Ship"));
        ships.Add(GameObject.Find("Globe Trotter Ship"));
        ships.Add(GameObject.Find("CyberpunkDeLorean"));
        ships.Add(GameObject.Find("SchoolBus"));
        ships.Add(GameObject.Find("Tie_Fighter"));

        positions.Add(new Vector3(transform.position.x - line, transform.position.y, transform.position.z - row));
        positions.Add(new Vector3(transform.position.x + line, transform.position.y, transform.position.z - row));
        positions.Add(new Vector3(transform.position.x - (line * 2), transform.position.y, transform.position.z - (row * 2)));
        positions.Add(new Vector3(transform.position.x, transform.position.y, transform.position.z - (row * 2)));
        positions.Add(new Vector3(transform.position.x + (line * 2), transform.position.y, transform.position.z - (row * 2)));
    }

    // Update is called once per frame
    void Update()
    {
        if(chaseTarget)
        {
            //move lead ship to target
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * moveSpeed);

            //transform.LookAt(target.transform);
            Vector3 direction = target.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
        
        //move target
        //target.transform.position = target.transform.position + Vector3.forward;

        if (moveToFormation)
            MoveFormation();
    }

    void MoveFormation()
    {
        for (int i = 0; i < ships.Count; i++)
        {
            ships[i].transform.position = Vector3.Lerp(ships[i].transform.position, positions[i], Time.time * lerpTime);
        }
    }

    private IEnumerator Formation(float time)
    {
        Debug.Log("Started");
        moveToFormation = true;
        chaseTarget = false;
        yield return new WaitForSeconds(time);
        moveToFormation = false;
        chaseTarget = true;
        Debug.Log("Finished");
    }
}
