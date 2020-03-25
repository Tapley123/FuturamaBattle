using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [SerializeField] private float deleteBulletTime = 5f;
    [SerializeField] private float speed = 20f;

    private void Awake()
    {
        StartCoroutine(DeleteBulletCoroutine(deleteBulletTime));
    }

    void Update()
    {
        transform.position += (Vector3.left * -1) * Time.deltaTime * speed;
    }

    IEnumerator DeleteBulletCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }

}
