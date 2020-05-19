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

        //add the formation positions
        positions.Add(new Vector3(planetExpressTransform.position.x - line, planetExpressTransform.position.y, planetExpressTransform.position.z - row));
        positions.Add(new Vector3(planetExpressTransform.position.x + line, planetExpressTransform.position.y, planetExpressTransform.position.z - row));
        positions.Add(new Vector3(planetExpressTransform.position.x - (line * 2), planetExpressTransform.position.y, planetExpressTransform.position.z - (row * 2)));
        positions.Add(new Vector3(planetExpressTransform.position.x, planetExpressTransform.position.y, planetExpressTransform.position.z - (row * 2)));
        positions.Add(new Vector3(planetExpressTransform.position.x + (line * 2), planetExpressTransform.position.y, planetExpressTransform.position.z - (row * 2)));

        //add the bullet spawn Positions
        for(int i = 0; i < 6; i++)
        {
            bulletPosition.Add(GameObject.Find(i + "_BulletSpawn").transform);
        }

        guns.Add(GameObject.Find("Gun_PlanetExpress"));
        guns.Add(GameObject.Find("Gun_MobShip"));
        guns.Add(GameObject.Find("Gun_GlobeTrotter"));
        guns.Add(GameObject.Find("Gun_Delorian"));
        guns.Add(GameObject.Find("Gun_SchoolBus"));
        guns.Add(GameObject.Find("Gun_TieFighter"));

        //add deathstars and targets
        for (int i = 0; i < 6; i++)
        {
            deathStars.Add(GameObject.Find("0_Target (" + i + ")"));
            targets.Add(GameObject.Find("0_Target (" + i + ")").GetComponent<DeathstarMovement>());
        }
    }
}
