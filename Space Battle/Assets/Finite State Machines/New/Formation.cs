using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formation : Base
{
    private float lerpTime = 0.01f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        for (int i = 0; i < ships.Count; i++)
        {
            ships[i].transform.position = Vector3.Lerp(ships[i].transform.position, positions[i], Time.time * lerpTime);
        }
        

        //check if in formation
        if(ships[1].transform.position.x <= positions[1].x + 5)
        {
            //Debug.Log("In Position");
            animator.SetTrigger("InFormation");
        }
    }
}
