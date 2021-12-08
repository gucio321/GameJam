using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;

    public void OnEscape()
    {
        // TODO: call game pause
        // TODO: need to unlock mouse because it is hidden by PlayerController system
        Cursor.lockState = CursorLockMode.None;

        var active = canvas.activeSelf;
        if (active)
        {
            OnMenuDisable();
        }
        else
        {
            OnMenuEnable();
        }
    }

    private void OnMenuEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        canvas.SetActive(true);
    }

    private void OnMenuDisable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        canvas.SetActive(false);
    }
}
