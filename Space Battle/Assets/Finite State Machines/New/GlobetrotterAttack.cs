using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobetrotterAttack : Base
{
    private Transform globeTrotterShipTransform;
    private Transform gun;
    private Transform bulletTarget;
    public float speed = 30f;

    public GameObject bullet;
    private float elapsed = 0f;
    public float timeInbetweenBullets = 0.3f; // time inbetween each bullet firing

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        globeTrotterShipTransform = GameObject.Find("Globe Bball").transform;
        bulletTarget = GameObject.Find("SatTarget").transform;
        gun = GameObject.Find("BballGun").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        gun.LookAt(bulletTarget);

        //move lead ship to target
        globeTrotterShipTransform.position = Vector3.MoveTowards(globeTrotterShipTransform.position, bulletTarget.position, Time.deltaTime * speed);

        //transform.LookAt(target.transform);
        Vector3 direction = bulletTarget.position - globeTrotterShipTransform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        globeTrotterShipTransform.rotation = Quaternion.Lerp(globeTrotterShipTransform.rotation, rotation, rotationSpeed * Time.deltaTime);


        float distance = Vector3.Distance(globeTrotterShipTransform.position, bulletTarget.position);

        if (distance < 500)//stop moving if close enough to target
        {
            guns[1].transform.LookAt(Base.target);
            elapsed += Time.deltaTime; // get time that elapsed
            if (elapsed >= timeInbetweenBullets)// && shoot)
            {
                elapsed = elapsed % timeInbetweenBullets; //reset the timer

                GameObject instance = GameObject.Instantiate(bullet, gun.position, gun.rotation);
                instance.transform.forward = gun.forward;
                instance.transform.parent = GameObject.Find("BulletHolder").transform;
            }
        }
    }
}