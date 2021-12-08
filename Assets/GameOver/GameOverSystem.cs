using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSystem : MonoBehaviour
{
    public void OnExitClicked()
    {
        // SceneManager.LoadScene("main menu")
        Debug.Log("exit clicked - exit to main menu");
    }

    public void OnReloadClicked()
    {
        Debug.Log("reload clicked - should reload game");
    }
}
