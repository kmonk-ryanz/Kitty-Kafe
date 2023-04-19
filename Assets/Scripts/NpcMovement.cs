using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{

    
    public string[] dialogues;
    
    void Start()
    {
        
        int randIndex = Random.Range(0, dialogues.Length); 
        string dialogue = dialogues[randIndex];
        Debug.Log(dialogue);
    }

    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            int randIndex = Random.Range(0, dialogues.Length); 
            string dialogue = dialogues[randIndex];
            Debug.Log(dialogue);
        }
    }
}
