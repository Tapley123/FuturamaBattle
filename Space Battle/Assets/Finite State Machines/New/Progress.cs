using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : Base
{
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
        if (!targets[0].alive)
            animator.SetTrigger("DeathStar1Destroyed");

        //if (!targets[1].alive)
            //animator.SetTrigger("DeathStar2Destroyed");

        if (!targets[2].alive)
            animator.SetTrigger("DeathStar3Destroyed");

        if (!targets[3].alive)
            animator.SetTrigger("DeathStar4Destroyed");

        //if (!targets[4].alive)
            //animator.SetTrigger("DeathStar5Destroyed");

        if (!targets[5].alive)
            animator.SetTrigger("DeathStar6Destroyed");

        if (!targets[6].alive)
            animator.SetTrigger("DeathStar7Destroyed");
    }

}
