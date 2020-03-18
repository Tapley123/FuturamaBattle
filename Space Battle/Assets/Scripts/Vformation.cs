using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vformation : MonoBehaviour
{
    private Transform planetExpressPos, mobShipPos, globetrotterPos, deloreanPos, schoolbusPos, tieFighterPos;
    private GameObject planetExpressShip, mobShip, globetrotterShip, deloreanShip, schoolbusShip, tieFighterShip;
    private float LerpValue = 0f;
    public float fallIntoPositionTime = 10f;


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
    }

    void Start()
    {

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
            planetExpressShip.transform.position = Vector3.Lerp(planetExpressShip.transform.position, planetExpressPos.position, LerpValue);
            mobShip.transform.position = Vector3.Lerp(mobShip.transform.position, mobShipPos.position, LerpValue);
            globetrotterShip.transform.position = Vector3.Lerp(globetrotterShip.transform.position, globetrotterPos.position, LerpValue);
            deloreanShip.transform.position = Vector3.Lerp(deloreanShip.transform.position, deloreanPos.position, LerpValue);
            schoolbusShip.transform.position = Vector3.Lerp(schoolbusShip.transform.position, schoolbusPos.position, LerpValue);
            tieFighterShip.transform.position = Vector3.Lerp(tieFighterShip.transform.position, tieFighterPos.position, LerpValue);
        }
        else
            LerpValue = 0;
    }
}
