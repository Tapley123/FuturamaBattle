﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTargetDestroyed : Base
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        for (int i = 0; i < deathStars.Count; i++)
        {
            if (!deathStars[i].GetComponent<DeathstarMovement>().alive)
            {
                deathStars.Remove(deathStars[i]);
            }
        }
    }
}
