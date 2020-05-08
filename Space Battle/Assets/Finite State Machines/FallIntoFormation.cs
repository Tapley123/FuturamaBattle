using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallIntoFormation : VFBase
{
    public float distance = 10f;
    public float LerpValue = 0f;
    public float rotationLookAtDistance = 10f; //so the ships face a position a bit in front of their position to stop them spinning in place

    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //lerp to position
        if (LerpValue < 1)
        {
            LerpValue += Time.deltaTime / fallIntoPositionTime;
            ships[0].transform.position = Vector3.Lerp(ships[0].transform.position, positions[0], LerpValue); //move to position
            ships[1].transform.position = Vector3.Lerp(ships[1].transform.position, positions[1], LerpValue); //move to position
            ships[2].transform.position = Vector3.Lerp(ships[2].transform.position, positions[2], LerpValue); //move to position
            ships[3].transform.position = Vector3.Lerp(ships[3].transform.position, positions[3], LerpValue); //move to position
            ships[4].transform.position = Vector3.Lerp(ships[4].transform.position, positions[4], LerpValue); //move to position
            ships[5].transform.position = Vector3.Lerp(ships[5].transform.position, positions[5], LerpValue); //move to position
        }
        else
            LerpValue = 0;

        //rotation
        ships[0].transform.LookAt(new Vector3(positions[0].x + rotationLookAtDistance, positions[0].y, positions[0].z));
        ships[1].transform.LookAt(new Vector3(positions[1].x + rotationLookAtDistance, positions[1].y, positions[1].z));
        ships[2].transform.LookAt(new Vector3(positions[2].x + rotationLookAtDistance, positions[2].y, positions[2].z));
        ships[3].transform.LookAt(new Vector3(positions[3].x + rotationLookAtDistance, positions[3].y, positions[3].z));
        ships[4].transform.LookAt(new Vector3(positions[4].x + rotationLookAtDistance, positions[4].y, positions[4].z));
        ships[5].transform.LookAt(new Vector3(positions[5].x + rotationLookAtDistance, positions[5].y, positions[5].z));
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
