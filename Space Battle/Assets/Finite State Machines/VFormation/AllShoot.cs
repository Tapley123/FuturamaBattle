using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllShoot : VFBase
{
    private float elapsed = 0f;
    private float timeInbetweenBullets = 0.3f; // time inbetween each bullet firing

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);

        elapsed += Time.deltaTime; // get time that elapsed
        if (elapsed >= timeInbetweenBullets)// && shoot)
        {
            elapsed = elapsed % timeInbetweenBullets; //reset the timer
            for(int i = 0; i < bulletSpawnPositions.Length; i++)
            {
                GameObject instance = GameObject.Instantiate(bullet, bulletSpawnPositions[i].position, bulletSpawnPositions[i].rotation);
                instance.transform.forward = bulletSpawnPositions[i].forward;
                instance.transform.parent = GameObject.Find("BulletHolder").transform;
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
