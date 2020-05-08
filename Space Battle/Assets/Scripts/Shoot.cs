using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletSpawn;

    private float bulletSpeed = 20f;

    public bool shoot = false;
    private float elapsed = 0f;
    private float timeInbetweenBullets = 0.3f; // time inbetween each bullet firing

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject.Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        }


        elapsed += Time.deltaTime; // get time that elapsed
        if (elapsed >= timeInbetweenBullets && shoot)
        {
            elapsed = elapsed % timeInbetweenBullets; //reset the timer
            ShootBullet();
        }


    }

    void ShootBullet()
    {
        GameObject instance = GameObject.Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        instance.transform.forward = bulletSpawn.transform.forward;
    }
}
