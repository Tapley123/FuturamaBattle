using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //public GameObject menu;

    private void Awake()
    {
        //menu.SetActive(false);
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("Game");
        //menu.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
