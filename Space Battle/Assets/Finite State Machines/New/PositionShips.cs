using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionShips : Base
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //globetrottership
        //ships[1]

        //schoolbus
        //ships[3]

        //tiefighter
        //ships[4]
    }
}
