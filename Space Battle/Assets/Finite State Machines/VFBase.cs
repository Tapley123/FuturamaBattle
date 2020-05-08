using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFBase : StateMachineBehaviour
{
    public float fallIntoPositionTime = 3f;
    public GameObject[] ships = new GameObject[6];
    public Vector3[] positions = new Vector3[6];
    

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //assaign the ships
        ships[0] = GameObject.Find("Planet Express 1");
        ships[1] = GameObject.Find("Mob Ship");
        ships[2] = GameObject.Find("Globe Trotter Ship");
        ships[3] = GameObject.Find("CyberpunkDeLorean");
        ships[4] = GameObject.Find("SchoolBus");
        ships[5] = GameObject.Find("Tie_Fighter");

        //assaign the v formation positions
        positions[0] = GameObject.Find("PlanetExpress Pos").transform.position;
        positions[1] = GameObject.Find("MobShip Pos").transform.position;
        positions[2] = GameObject.Find("GlobeTrotter Pos").transform.position;
        positions[3] = GameObject.Find("Delorean Pos").transform.position;
        positions[4] = GameObject.Find("SchoolBus Pos").transform.position;
        positions[5] = GameObject.Find("TieFighter Pos").transform.position;
    }
}
