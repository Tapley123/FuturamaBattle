using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banking : Base
{
    public float angleOfRotation = 80f;
    public float rotSpeed = 1f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //rotate planet express ship by 60 degrees and move forward
        planetExpressTransform.position = Vector3.MoveTowards(planetExpressTransform.position, target.transform.position, Time.deltaTime * moveSpeed);

        //planetExpressTransform.eulerAngles = new Vector3(planetExpressTransform.eulerAngles.x, planetExpressTransform.eulerAngles.y, 80);

        Quaternion rotation = Quaternion.Euler(planetExpressTransform.eulerAngles.x, planetExpressTransform.eulerAngles.y, angleOfRotation);
        planetExpressTransform.rotation = Quaternion.Lerp(planetExpressTransform.rotation, rotation, Time.deltaTime * rotSpeed);
    }


}
