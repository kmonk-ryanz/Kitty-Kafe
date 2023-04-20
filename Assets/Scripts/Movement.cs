using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public float delayTime = 10f;
    public float moveSpeed = 2f;
    
    void Start()
    {
        transform.position = new Vector3(-11, 3, 0);
        Invoke("MoveNPC", delayTime);
    }

    private void MoveNPC()
    {
        transform.Translate(new Vector3(moveSpeed, 3, 0) * Time.deltaTime);
        Vector3 newPosition = transform.position;
        newPosition.x += moveSpeed * Time.deltaTime;
        transform.position = newPosition;
    }
}

