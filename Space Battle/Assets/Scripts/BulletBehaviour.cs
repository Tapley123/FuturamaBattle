using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private float deleteBulletTime = 5f;
    [SerializeField] private float speed = 20f;
    private Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(DeleteBulletCoroutine(deleteBulletTime));
    }

    void Update()
    {
        //rb.AddForce(Vector3.forward * speed, ForceMode.Impulse);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    IEnumerator DeleteBulletCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }

}
