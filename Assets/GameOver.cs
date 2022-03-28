using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public void Return()
    {
        SceneManager.LoadScene("firstlvl");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Exit ()
    {
        Application.Quit();
    }
}
