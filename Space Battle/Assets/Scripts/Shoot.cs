using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;

    public bool shoot = false;
    float timer = 0;
    private float timeInbetweenAutoFire = 3f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject.Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        }



        while (shoot)
        {
            InvokeRepeating("ShootBullet", 0f, 10f);
            //StartCoroutine(ShootCoroutine(1));
        }
    }

    void ShootBullet()
    {
        GameObject.Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
    }

    public IEnumerator ShootCoroutine(float time)
    {
        bool flag = true;

        while (flag)
        {
            Debug.Log("Bam");
            GameObject.Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            yield return new WaitForSeconds(time);
        }
    }
}
