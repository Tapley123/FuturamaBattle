using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : Base
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(target != null)
        {
            //move lead ship to target
            planetExpressTransform.position = Vector3.MoveTowards(planetExpressTransform.position, target.transform.position, Time.deltaTime * moveSpeed);

            //transform.LookAt(target.transform);
            Vector3 direction = target.transform.position - planetExpressTransform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            planetExpressTransform.rotation = Quaternion.Lerp(planetExpressTransform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }
}
