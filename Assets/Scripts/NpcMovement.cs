using System.Collections;
using System.Collections.Generic;
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
        transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime); // Move NPC horizontally
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randIndex = Random.Range(0, dialogues.Length); // Choose a random dialogue
            string dialogue = dialogues[randIndex];
            Debug.Log(dialogue);
        }
    }
}
