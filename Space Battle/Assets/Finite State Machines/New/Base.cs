using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : StateMachineBehaviour
{
    public List<GameObject> ships = new List<GameObject>();
    public List<Vector3> positions = new List<Vector3>();
    private Transform planetExpressTransform;
    private float row = 20f, line = 20f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        planetExpressTransform = GameObject.Find("Planet Express 1").transform;

        ships.Add(GameObject.Find("Mob Ship"));
        ships.Add(GameObject.Find("Globe Trotter Ship"));
        ships.Add(GameObject.Find("CyberpunkDeLorean"));
        ships.Add(GameObject.Find("SchoolBus"));
        ships.Add(GameObject.Find("Tie_Fighter"));

        positions.Add(new Vector3(planetExpressTransform.position.x - line, planetExpressTransform.position.y, planetExpressTransform.position.z - row));
        positions.Add(new Vector3(planetExpressTransform.position.x + line, planetExpressTransform.position.y, planetExpressTransform.position.z - row));
        positions.Add(new Vector3(planetExpressTransform.position.x - (line * 2), planetExpressTransform.position.y, planetExpressTransform.position.z - (row * 2)));
        positions.Add(new Vector3(planetExpressTransform.position.x, planetExpressTransform.position.y, planetExpressTransform.position.z - (row * 2)));
        positions.Add(new Vector3(planetExpressTransform.position.x + (line * 2), planetExpressTransform.position.y, planetExpressTransform.position.z - (row * 2)));
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
