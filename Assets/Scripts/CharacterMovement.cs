using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public GameObject objectToReceive;
    public float speed = 5f;

    private bool hasReceivedObject = false;
    private bool isLeaving = false;
    private Vector3 targetPosition;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == objectToReceive && !hasReceivedObject)
        {
            hasReceivedObject = true;
            targetPosition = transform.position + new Vector3(5f, 0f, 0f);
        }
    }

    void Update()
    {
        if (hasReceivedObject && !isLeaving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            if (transform.position == targetPosition)
            {
                isLeaving = true;
                targetPosition = transform.position - new Vector3(5f, 0f, 0f);
            }
        }
        else if (isLeaving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            if (transform.position == targetPosition)
            {
                Destroy(gameObject);
            }
        }
    }

}
