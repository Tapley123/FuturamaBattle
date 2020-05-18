using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionShips : Base
{
    //public List<Vector3> pos = new List<Vector3>();
    //public float speed = 1f;
    public GameObject bankingShips;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        //pos.Add(new Vector3(-10925, 0, -6060));
        //pos.Add(new Vector3(-10539, 91, -6124));
        //pos.Add(new Vector3(-10461, 147, -5652));
        Instantiate(bankingShips);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //globetrottership
        //ships[1].transform.position = Vector3.MoveTowards(ships[1].transform.position, pos[0], Time.deltaTime * speed);

        //schoolbus
        //ships[3].transform.position = Vector3.MoveTowards(ships[3].transform.position, pos[1], Time.deltaTime * speed);

        //tiefighter
        //ships[4].transform.position = Vector3.MoveTowards(ships[4].transform.position, pos[2], Time.deltaTime * speed);
    }
}
