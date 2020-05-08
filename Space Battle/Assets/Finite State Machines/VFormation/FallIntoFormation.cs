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
        for (int i = 0; i <= formationPositions.Length - 1; i++)
        {
            ships[i].transform.LookAt(new Vector3(formationPositions[i].x + rotationLookAtDistance, formationPositions[i].y, formationPositions[i].z)); //rotate to position
        }

        //lerp to position
        if (LerpValue < 1)
        {
            LerpValue += Time.deltaTime / fallIntoPositionTime;
            for(int i = 0; i <= ships.Length - 1; i++)
            {
                ships[i].transform.position = Vector3.Lerp(ships[i].transform.position, formationPositions[i], LerpValue); //move to position
            }
        }
        else
            LerpValue = 0;

        //check if the ships are in formation
        float distance = Vector3.Distance(ships[0].transform.position, formationPositions[0]);
        if (distance <= 1)
            animator.SetBool("inFormation", true);
        else
            animator.SetBool("inFormation", false);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
