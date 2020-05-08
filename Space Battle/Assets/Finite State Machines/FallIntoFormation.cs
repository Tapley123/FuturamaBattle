using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallIntoFormation : VFBase
{
    public float distance = 10f;
    public float LerpValue = 0f;
    public float rotationLookAtDistance = 10f; //so the ships face a position a bit in front of their position to stop them spinning in place


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class
    }


    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //rotation
        for (int i = 0; i <= positions.Length - 1; i++)
        {
            ships[i].transform.LookAt(new Vector3(positions[i].x + rotationLookAtDistance, positions[i].y, positions[i].z)); //rotate to position
        }

        //lerp to position
        if (LerpValue < 1)
        {
            LerpValue += Time.deltaTime / fallIntoPositionTime;
            for(int i = 0; i <= ships.Length - 1; i++)
            {
                ships[i].transform.position = Vector3.Lerp(ships[i].transform.position, positions[i], LerpValue); //move to position
            }
        }
        else
            LerpValue = 0;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
