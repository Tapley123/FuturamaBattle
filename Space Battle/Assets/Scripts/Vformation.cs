using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vformation : MonoBehaviour
{
    [SerializeField] private Transform planetExpressPos, mobShipPos, globetrotterPos, deloreanPos, schoolbusPos, tieFighterPos;
    [SerializeField] private GameObject planetExpressShip, mobShipShip, globetrotterShip, deloreanShip, schoolbusShip, tieFighterShip;
    
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
        mobShipShip = GameObject.Find("Mob Ship");
        globetrotterShip = GameObject.Find("Globe Trotter Ship");
        deloreanShip = GameObject.Find("CyberpunkDeLorean");
        schoolbusShip = GameObject.Find("SchoolBus");
        tieFighterShip = GameObject.Find("Tie_Fighter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
