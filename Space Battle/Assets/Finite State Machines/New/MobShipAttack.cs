using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobShipAttack : Base
{
    private Transform mobShipTransform;
    private Transform deathStarTransform;
    public float speed = 30f;

    public GameObject bullet;
    private float elapsed = 0f;
    public float timeInbetweenBullets = 0.3f; // time inbetween each bullet firing

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        mobShipTransform = GameObject.Find("Mob Ship").transform;
        deathStarTransform = GameObject.Find("0_Target (5)").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float distance = Vector3.Distance(mobShipTransform.position, deathStarTransform.position);

        if(distance > 100 && deathStarTransform.GetComponent<DeathstarMovement>().alive)//stop moving if close enough to target
        {
            //move ship to target
            mobShipTransform.position = Vector3.MoveTowards(mobShipTransform.position, deathStarTransform.position, Time.deltaTime * speed);

            //transform.LookAt(target.transform);
            Vector3 direction = deathStarTransform.position - mobShipTransform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            mobShipTransform.rotation = Quaternion.Lerp(mobShipTransform.rotation, rotation, rotationSpeed * Time.deltaTime);


            guns[1].transform.LookAt(target);
            elapsed += Time.deltaTime; // get time that elapsed
            if (elapsed >= timeInbetweenBullets)// && shoot)
            {
                elapsed = elapsed % timeInbetweenBullets; //reset the timer

                GameObject instance = GameObject.Instantiate(bullet, bulletPosition[1].position, bulletPosition[1].rotation);
                instance.transform.forward = bulletPosition[1].forward;
                instance.transform.parent = GameObject.Find("BulletHolder").transform;
            }
        }
        else
            deathStars[5].GetComponent<DeathstarMovement>().health = 0;
    }
        
}

    

