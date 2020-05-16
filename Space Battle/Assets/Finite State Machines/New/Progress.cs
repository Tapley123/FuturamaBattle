using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : Base
{
    public DeathstarMovement deathStar3;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        deathStar3 = GameObject.Find("0_Target (2)").GetComponent<DeathstarMovement>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(!deathStar3.alive)
        {
            animator.SetTrigger("DeathStar3Destroyed");
        }
    }

}
