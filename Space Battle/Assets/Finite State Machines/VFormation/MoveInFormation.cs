using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInFormation : VFBase
{

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);

        

        
        for (int i = 0; i <= ships.Length - 1; i++)
        {
            if(currentTarget.GetComponent<DeathstarMovement>().alive)
            {
                ships[i].transform.position = Vector3.MoveTowards(ships[i].transform.position, currentTarget.position, 3 * Time.deltaTime);
                //ships[i].transform.LookAt(new Vector3(currentTarget.position.x, currentTarget.position.y, currentTarget.position.z)); //rotate to position
                //ships[i].transform.rotation = Quaternion.RotateTowards(ships[i].transform.rotation, Quaternion.LookRotation(currentTarget.position - ships[i].transform.position), Time.time * shipRotationSpeed); //rotate to position
                //ships[i].transform.rotation = Quaternion.Lerp(ships[i].transform.rotation, Quaternion.LookRotation(currentTarget.position - ships[i].transform.position), Time.time * shipRotationSpeed); //rotate to position
                guns[i].transform.rotation = Quaternion.Lerp(guns[i].transform.rotation, Quaternion.LookRotation(currentTarget.position - guns[i].transform.position), Time.time * shipRotationSpeed); //rotate to position
            }
        }
    }
}
