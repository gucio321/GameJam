using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestWritter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textField;

    private class prop
    {
        public string line;
        public bool strikethough;

        public prop(string l, bool s)
        {
            line = l;
            strikethough = s;
        }
    }

    private List<prop> linesToWrite;
    private bool shouldRebuild = false;

    // PushLine adds new line+st and strikethough value to quest log.
    // if the line already exists, it logs an error
    public void PushLine(string line, bool strikethough)
    {
        var newProp = new prop(line, strikethough);
        foreach (prop item in linesToWrite)
        {
            if (item == newProp)
            {
                Debug.LogErrorFormat("PushLine: line {0} already exists", line);
            }
        }

        linesToWrite.Add(newProp);
        shouldRebuild = true;
    }

    // Strikethough 
    public bool Strikethough(int line)
    {
        if (line >= linesToWrite.Count)
        {
            return false;
        }
        linesToWrite[line].strikethough = true;
        return true;
    }

    public bool Strikethough(string l)
    {
        for (int i = 0; i < linesToWrite.Count; i++)
        {
            if (linesToWrite[i].line == l)
            {
                Strikethough(i);
                return true;
            }
        }

        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        linesToWrite = new List<prop>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldRebuild)
        {
            Rebuild();
        }

    }

    private void Rebuild()
    {
        foreach (prop line in linesToWrite)
        {
            string newLine = "";
            if (line.strikethough)
            {
                newLine += "<s>";
            }

            newLine += "> ";

            newLine += line.line.Replace("\n", "\n   ");

            if (line.strikethough)
            {
                newLine += "</s>";
            }

            newLine += "\n";

            textField.text += newLine;
            Debug.LogFormat("adding line {0}", textField.text);
        }

        shouldRebuild = false;
    }
}
