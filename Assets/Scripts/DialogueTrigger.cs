using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTrigger : MonoBehaviour
{
    public string[] dialogueLines;
    public GameObject textBox;
    private int currentLine = 0;

    void Start()
    {
        textBox.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textBox.SetActive(true);
            DisplayLine();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentLine++;

            if (currentLine < dialogueLines.Length)
            {
                DisplayLine();
            }
            else
            {
                textBox.SetActive(false);
                currentLine = 0;
            }
        }
    }

    void DisplayLine()
    {
        textBox.GetComponentInChildren<Text>().text = dialogueLines[currentLine];
    }
}

