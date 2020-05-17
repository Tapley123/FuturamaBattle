using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatBanking : Base
{
    public float angleOfRotation1 = 10f, angleOfRotation2 = -10f;
    public float rotSpeed = 1f;
    public Transform mobShipTransform;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        mobShipTransform = GameObject.Find("Mob Ship").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(mobShipTransform.rotation.eulerAngles.z >= angleOfRotation1 - 1)
        {
            Quaternion rotation = Quaternion.Euler(mobShipTransform.eulerAngles.x, mobShipTransform.eulerAngles.y, angleOfRotation2);
            mobShipTransform.rotation = Quaternion.Lerp(mobShipTransform.rotation, rotation, Time.deltaTime * rotSpeed);
        }

        if (mobShipTransform.rotation.eulerAngles.z <= angleOfRotation2 + 1)
        {
            Quaternion rotation = Quaternion.Euler(mobShipTransform.eulerAngles.x, mobShipTransform.eulerAngles.y, angleOfRotation1);
            mobShipTransform.rotation = Quaternion.Lerp(mobShipTransform.rotation, rotation, Time.deltaTime * rotSpeed);
        }
    }
}
