using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterWritter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textField;

    private string text;

    [ContextMenu("print")]
    private void print()
    {
        WriteText("Hello world");
    }

    public void WriteText(string t)
    {
        textField.text = t;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
