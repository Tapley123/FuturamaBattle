using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //private Vformation vFormation;
    private bool shoot1 = true;//first time shooting in v formation
    [SerializeField] private float shoot1Duration = 2f;//length of firsttime shooting
    void Start()
    {
       // vFormation = GameObject.Find("V Formation").GetComponent<Vformation>();
    }

    void Update()
    {
        /////////////////////////////////////////////////First Shoot///////////////////////////////////////////
        if(shoot1 && Vformation.inFormation)
        {
            Vformation.allShoot = true;
            StartCoroutine(Shoot1Coroutine(shoot1Duration));
        }
        /////////////////////////////////////////////////First Shoot///////////////////////////////////////////
    }

    public IEnumerator Shoot1Coroutine(float time)
    {
        yield return new WaitForSeconds(time);
        //Debug.Log("Done");
        shoot1 = false;
        Vformation.allShoot = false;
    }
}
