using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TheEndController : MonoBehaviour
{
    [SerializeField]
    private float showSpeed;

    [SerializeField]
    private Image[] images;
    [SerializeField]
    private TMP_Text[] texts;

    private float currentAlpha = 0f;

    private void OnValidate()
    {
        if (images == null || images.Length == 0)
        {
            Debug.LogError("there is no image set");
        }
        if (showSpeed <= 0)
        {
            Debug.LogError("showing speed is 0!");
        }
    }

    void Awake()
    {
        updateAlpha(0);
    }

    // Update is called once per frame
    void Update()
    {
        currentAlpha += Time.deltaTime * showSpeed;
        updateAlpha(currentAlpha);
        if (currentAlpha >= 1)
        {
            enabled = false;
        }
    }

    private void updateAlpha(float newAlpha)
    {
        foreach (Image img in images)
        {

            var col = img.color;
            col.a = newAlpha;
            img.color = col;
        }

        foreach (TMP_Text text in texts)
        {
            var col = text.color;
            col.a = newAlpha;
            text.color = col;
        }
    }
}
