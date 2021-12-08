using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    public void OnPlayClicked()
    {
        Debug.Log("loading game scene");
        Debug.LogError("Scene name is not set. please edit this script and add it");
        //SceneManager.LoadScene("");
    }
    public void OnExitClicked()
    {
        Debug.Log("Game is going down");
        Application.Quit();
    }
}
