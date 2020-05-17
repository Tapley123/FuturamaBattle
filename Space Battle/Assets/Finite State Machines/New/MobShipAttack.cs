using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobShipAttack : Base
{
    private Transform mobShipTransform;
    private Transform deathStarTransform;
    public float speed = 30f;
    public GameObject bullet;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        mobShipTransform = GameObject.Find("Mob Ship").transform;
        deathStarTransform = GameObject.Find("0_Target (5)").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //move lead ship to target
        mobShipTransform.position = Vector3.MoveTowards(mobShipTransform.position, deathStarTransform.position, Time.deltaTime * speed);

        //transform.LookAt(target.transform);
        Vector3 direction = deathStarTransform.position - mobShipTransform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        mobShipTransform.rotation = Quaternion.Lerp(mobShipTransform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    
}
