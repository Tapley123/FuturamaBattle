using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public float angleOfRotation = 80f;
    public float rotSpeed = 1f;
    public float moveSpeed = 0.5f;
    public float timeTillBank = 1f;
    private bool bank = false;

    void Start()
    {
        StartCoroutine(WaitCoroutine(timeTillBank));
    }

    
    void Update()
    {
        if(bank)
        {
            transform.position = new Vector3(transform.position.x + moveSpeed, transform.position.y - (moveSpeed / 2), transform.position.z - (moveSpeed / 4));
            Quaternion rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, angleOfRotation);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotSpeed);
        }
    }

    private IEnumerator WaitCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        bank = true;

    }
}
