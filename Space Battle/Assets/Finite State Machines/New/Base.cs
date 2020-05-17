using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : StateMachineBehaviour
{
    public static List<GameObject> ships = new List<GameObject>();
    public static List<Vector3> positions = new List<Vector3>();
    public static List<Transform> bulletPosition = new List<Transform>();
    public static List<GameObject> guns = new List<GameObject>();
    public static List<GameObject> deathStars = new List<GameObject>();
    public static List<DeathstarMovement> targets = new List<DeathstarMovement>();
    public static Transform planetExpressTransform;
    public static Transform target;
    public static float moveSpeed = 10f, rotationSpeed = 1f;

    
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

        bulletPosition.Add(GameObject.Find("0_BulletSpawn").transform);
        bulletPosition.Add(GameObject.Find("1_BulletSpawn").transform);
        bulletPosition.Add(GameObject.Find("2_BulletSpawn").transform);
        bulletPosition.Add(GameObject.Find("3_BulletSpawn").transform);
        bulletPosition.Add(GameObject.Find("4_BulletSpawn").transform);
        bulletPosition.Add(GameObject.Find("5_BulletSpawn").transform);

        guns.Add(GameObject.Find("Gun_PlanetExpress"));
        guns.Add(GameObject.Find("Gun_MobShip"));
        guns.Add(GameObject.Find("Gun_GlobeTrotter"));
        guns.Add(GameObject.Find("Gun_Delorian"));
        guns.Add(GameObject.Find("Gun_SchoolBus"));
        guns.Add(GameObject.Find("Gun_TieFighter"));

        deathStars.Add(GameObject.Find("0_Target"));
        deathStars.Add(GameObject.Find("0_Target (1)"));
        deathStars.Add(GameObject.Find("0_Target (2)"));
        deathStars.Add(GameObject.Find("0_Target (3)"));
        deathStars.Add(GameObject.Find("0_Target (4)"));
        deathStars.Add(GameObject.Find("0_Target (5)"));
        deathStars.Add(GameObject.Find("0_Target (6)"));
        deathStars.Add(GameObject.Find("0_Target (7)"));
        deathStars.Add(GameObject.Find("0_Target (8)"));

        targets.Add(GameObject.Find("0_Target").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (1)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (2)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (3)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (4)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (5)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (6)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (7)").GetComponent<DeathstarMovement>());
        targets.Add(GameObject.Find("0_Target (8)").GetComponent<DeathstarMovement>());
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
