using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vformation : MonoBehaviour
{
    private Transform planetExpressPos, mobShipPos, globetrotterPos, deloreanPos, schoolbusPos, tieFighterPos;
    private Vector3 planetExpressRotPos, mobShipRotPos, globetrotterRotPos, deloreanRotPos, schoolbusRotPos, tieFighterRotPos;
    private GameObject planetExpressShip, mobShip, globetrotterShip, deloreanShip, schoolbusShip, tieFighterShip;
    private Vector3 planetExpressDirection, mobShipDirection, globetrotterDirection, deloreanDirection, schoolbusDirection, tieFighterDirection;
    private Quaternion planetExpressQuaternion, mobShipQuaternion, globetrotterQuaternion, deloreanQuaternion, schoolbusQuaternion, tieFighterQuaternion;
    private float LerpValue = 0f;
    public float fallIntoPositionTime = 10f, rotationSpeed = 1f;
    [SerializeField] private float rotationLookAtDistance = 10f; //so the ships face a position a bit in front of their position to stop them spinning in place

    void Awake()
    {
        //V formation position transforms
        planetExpressPos = GameObject.Find("PlanetExpress Pos").transform;
        mobShipPos = GameObject.Find("MobShip Pos").transform;
        globetrotterPos = GameObject.Find("GlobeTrotter Pos").transform;
        deloreanPos = GameObject.Find("Delorean Pos").transform;
        schoolbusPos = GameObject.Find("SchoolBus Pos").transform;
        tieFighterPos = GameObject.Find("TieFighter Pos").transform;

        //Ships GameObjects
        planetExpressShip = GameObject.Find("Planet Express 1");
        mobShip = GameObject.Find("Mob Ship");
        globetrotterShip = GameObject.Find("Globe Trotter Ship");
        deloreanShip = GameObject.Find("CyberpunkDeLorean");
        schoolbusShip = GameObject.Find("SchoolBus");
        tieFighterShip = GameObject.Find("Tie_Fighter");

        //making the tarkets for the ships to rotate towards
        planetExpressRotPos = new Vector3(planetExpressPos.position.x + rotationLookAtDistance, planetExpressPos.position.y, planetExpressPos.position.z);
        mobShipRotPos = new Vector3(mobShipPos.position.x + rotationLookAtDistance, mobShipPos.position.y, mobShipPos.position.z);
        globetrotterRotPos = new Vector3(globetrotterPos.position.x + rotationLookAtDistance, globetrotterPos.position.y, globetrotterPos.position.z);
        deloreanRotPos = new Vector3(deloreanPos.position.x + rotationLookAtDistance, deloreanPos.position.y, deloreanPos.position.z);
        schoolbusRotPos = new Vector3(schoolbusPos.position.x + rotationLookAtDistance, schoolbusPos.position.y, schoolbusPos.position.z);
        tieFighterRotPos = new Vector3(tieFighterPos.position.x + rotationLookAtDistance, tieFighterPos.position.y, tieFighterPos.position.z);
    }

    void Start()
    {
        //Normalizing the directions
        planetExpressDirection = (planetExpressPos.position - planetExpressShip.transform.position).normalized; //target pos - current pos (Normalized)
        mobShipDirection = (mobShipPos.position - mobShip.transform.position).normalized;
        globetrotterDirection = (globetrotterPos.position - globetrotterShip.transform.position).normalized;
        deloreanDirection = (deloreanPos.position - deloreanShip.transform.position).normalized;
        schoolbusDirection = (schoolbusPos.position - schoolbusShip.transform.position).normalized;
        tieFighterDirection = (tieFighterPos.position - tieFighterShip.transform.position).normalized;

        //create the look at target rotation
        planetExpressQuaternion = Quaternion.LookRotation(planetExpressDirection);
        mobShipQuaternion = Quaternion.LookRotation(mobShipDirection);
        globetrotterQuaternion = Quaternion.LookRotation(globetrotterDirection);
        deloreanQuaternion = Quaternion.LookRotation(deloreanDirection);
        schoolbusQuaternion = Quaternion.LookRotation(schoolbusDirection);
        tieFighterQuaternion = Quaternion.LookRotation(tieFighterDirection);
    }

    // Update is called once per frame
    void Update()
    {
        FallIn();
    }

    private void FallIn()
    {
        //lerp to position
        if (LerpValue < 1)
        {
            LerpValue += Time.deltaTime / fallIntoPositionTime;
            planetExpressShip.transform.position = Vector3.Lerp(planetExpressShip.transform.position, planetExpressPos.position, LerpValue); //move to position
            mobShip.transform.position = Vector3.Lerp(mobShip.transform.position, mobShipPos.position, LerpValue);
            globetrotterShip.transform.position = Vector3.Lerp(globetrotterShip.transform.position, globetrotterPos.position, LerpValue);
            deloreanShip.transform.position = Vector3.Lerp(deloreanShip.transform.position, deloreanPos.position, LerpValue);
            schoolbusShip.transform.position = Vector3.Lerp(schoolbusShip.transform.position, schoolbusPos.position, LerpValue);
            tieFighterShip.transform.position = Vector3.Lerp(tieFighterShip.transform.position, tieFighterPos.position, LerpValue);
        }
        else
            LerpValue = 0;

        //rotation
        planetExpressShip.transform.LookAt(planetExpressRotPos);
        mobShip.transform.LookAt(mobShipRotPos);
        globetrotterShip.transform.LookAt(globetrotterRotPos);
        deloreanShip.transform.LookAt(deloreanRotPos);
        schoolbusShip.transform.LookAt(schoolbusRotPos);
        tieFighterShip.transform.LookAt(tieFighterRotPos);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(mobShipRotPos, 1);
    }
}
