using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("firstlvl");
    }

    public void Tit()
    {
        SceneManager.LoadScene("Titors");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
