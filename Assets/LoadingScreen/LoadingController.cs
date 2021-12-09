using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingController : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    public float CurrentProgress()
    {
        return slider.value;
    }

    [ContextMenu("Reset")]
    public void Reset()
    {
        slider.value = 0f;
    }

    public void SetProgress(float p)
    {
        slider.value = p;
    }
}
