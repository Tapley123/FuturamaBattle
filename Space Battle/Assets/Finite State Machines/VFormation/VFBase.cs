using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFBase : StateMachineBehaviour
{
    public float fallIntoPositionTime = 3f;
    public static GameObject[] ships = new GameObject[6];
    public static Vector3[] formationPositions = new Vector3[6];
    public static Transform[] bulletSpawnPositions = new Transform[6];
    public GameObject bullet;
    public static Animator animator;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator = GameObject.Find("V Formation").GetComponent<Animator>();

        //assaign the ships
        ships[0] = GameObject.Find("Planet Express 1");
        ships[1] = GameObject.Find("Mob Ship");
        ships[2] = GameObject.Find("Globe Trotter Ship");
        ships[3] = GameObject.Find("CyberpunkDeLorean");
        ships[4] = GameObject.Find("SchoolBus");
        ships[5] = GameObject.Find("Tie_Fighter");

        //assaign the v formation positions
        formationPositions[0] = GameObject.Find("PlanetExpress Pos").transform.position;
        formationPositions[1] = GameObject.Find("MobShip Pos").transform.position;
        formationPositions[2] = GameObject.Find("GlobeTrotter Pos").transform.position;
        formationPositions[3] = GameObject.Find("Delorean Pos").transform.position;
        formationPositions[4] = GameObject.Find("SchoolBus Pos").transform.position;
        formationPositions[5] = GameObject.Find("TieFighter Pos").transform.position;

        //bullet spawn positions
        bulletSpawnPositions[0] = GameObject.Find("0_BulletSpawn").transform;
        bulletSpawnPositions[1] = GameObject.Find("1_BulletSpawn").transform;
        bulletSpawnPositions[2] = GameObject.Find("2_BulletSpawn").transform;
        bulletSpawnPositions[3] = GameObject.Find("3_BulletSpawn").transform;
        bulletSpawnPositions[4] = GameObject.Find("4_BulletSpawn").transform;
        bulletSpawnPositions[5] = GameObject.Find("5_BulletSpawn").transform;
    }
}
