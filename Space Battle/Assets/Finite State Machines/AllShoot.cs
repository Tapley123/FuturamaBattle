using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllShoot : Base
{
    public GameObject bullet;
    private float elapsed = 0f;
    private float timeInbetweenBullets = 0.3f; // time inbetween each bullet firing

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);

        for (int i = 0; i < guns.Count; i++)
        {
            guns[i].transform.LookAt(target);
        }


        elapsed += Time.deltaTime; // get time that elapsed
        if (elapsed >= timeInbetweenBullets)// && shoot)
        {
            elapsed = elapsed % timeInbetweenBullets; //reset the timer
            for(int i = 0; i < bulletPosition.Count; i++)
            {
                GameObject instance = GameObject.Instantiate(bullet, bulletPosition[i].position, bulletPosition[i].rotation);
                instance.transform.forward = bulletPosition[i].forward;
                instance.transform.parent = GameObject.Find("BulletHolder").transform;
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
