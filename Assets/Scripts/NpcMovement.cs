using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcMovement : MonoBehaviour
{

    public float moveSpeed;
    public string[] dialogues;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0); 
        int randIndex = Random.Range(0, dialogues.Length); 
        string dialogue = dialogues[randIndex];
        Debug.Log(dialogue);
    }

    
    void Update()
    {
        transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime); 
        
        if (Input.GetMouseButtonDown(0))
        {
            int randIndex = Random.Range(0, dialogues.Length); 
            string dialogue = dialogues[randIndex];
            Debug.Log(dialogue);
        }
    }
}
