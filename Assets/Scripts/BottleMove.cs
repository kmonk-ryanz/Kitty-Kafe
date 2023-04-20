using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleMove : MonoBehaviour
{
    public float dragSpeed = 10f;
    private bool isDragging = false;
    private Vector3 startPosition;
    private float distance;

    void OnMouseDown()
    {
        isDragging = true;
        startPosition = transform.position;
        distance = Camera.main.WorldToScreenPoint(transform.position).z;
    }

    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector3(objPosition.x, objPosition.y, startPosition.z);
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    // private void OnMouseDown()
    // {
    //     Rigidbody2D rb = GetComponent<Rigidbody2D>();
    //     rb.velocity = new Vector2(0f, 5f);
    // }

}
