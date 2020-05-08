using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDeathStar : VFBase
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);

        

        for(int i = 0; i < deathStars.Length; i++)
        {
            if(deathStars[i].GetComponent<DeathstarMovement>().alive)
            {
                currentTarget = deathStars[i].transform;
                break;
            }
        }

        //Debug.Log("Current Target = " + currentTarget);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
