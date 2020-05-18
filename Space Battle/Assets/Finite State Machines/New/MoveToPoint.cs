using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : Base
{
    public float speed = 40f;
    private Transform moveToPoint;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        //moveToPoint = GameObject.Find("0_Target (4)").transform;
        moveToPoint = target.transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //move lead ship to target
        planetExpressTransform.position = Vector3.MoveTowards(planetExpressTransform.position, moveToPoint.position, Time.deltaTime * speed);
    }
}
