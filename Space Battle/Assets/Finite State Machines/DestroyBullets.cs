using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : Base
{
    [SerializeField] private Transform[] bullets;
    private Transform bulletHolder;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex); //call the enter state from the base class

        bulletHolder = GameObject.Find("BulletHolder").transform;
        bullets = new Transform[bulletHolder.childCount];

        for (int i = 0; i < bulletHolder.childCount; i++)
        {
            bullets[i] = bulletHolder.GetChild(i);
            Destroy(bullets[i].gameObject);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);
    }
}
