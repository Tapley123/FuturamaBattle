using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera vFormationCamera, planetExpressTurretCamera;
    public bool boolVFormationCamera = true, boolPlanetExpressTurretCamera = false;

    public bool bool1 = true, bool2 = false;

    void Start()
    {
        vFormationCamera.enabled = true;
        planetExpressTurretCamera.enabled = false;
    }

    
    void Update()
    {
        DisableOtherCameras();
        ChangeCamsWithInput();
    }

    private void ChangeCamsWithInput()
    {
        //when button 1 is pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            boolVFormationCamera = true;
            boolPlanetExpressTurretCamera = false;
        }
        //
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            boolVFormationCamera = false;
            boolPlanetExpressTurretCamera = true;
        }
    }

    private void DisableOtherCameras()
    {
        if(boolVFormationCamera)
        {
            vFormationCamera.enabled = true;
            planetExpressTurretCamera.enabled = false;
        }
        if(boolPlanetExpressTurretCamera)
        {
            vFormationCamera.enabled = false;
            planetExpressTurretCamera.enabled = true;
        }
    }
}
