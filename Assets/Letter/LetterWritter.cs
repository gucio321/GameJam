using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterWritter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textField;
    [SerializeField, Tooltip("time (in seconds) between each print of letter")]
    private float writterTimeDelta;

    private string text;
    private float currentWritterTimeDelta;
    private int currentLetter = 0;
    private bool shouldWrite = false;

    public void WriteText(string t)
    {
        text = t;
        shouldWrite = true;
    }

    [ContextMenu("Clear")]
    public void Clear()
    {
        textField.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!shouldWrite)
        {
            return;
        }

        currentWritterTimeDelta += Time.deltaTime;

        // check if there is a time to write next letter
        if (currentWritterTimeDelta >= writterTimeDelta)
        {
            currentWritterTimeDelta = 0;
            textField.text = textField.text + text[currentLetter];
            currentLetter++;
        }

        // check if all the message was written
        if (currentLetter == text.Length - 1)
        {
            // turn off everything
            shouldWrite = false;
            text = null;
            currentLetter = 0;
            currentWritterTimeDelta = 0;
        }
    }
}
