using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public KeyCode pourKey = KeyCode.Space;
    public float pourSpeed = 100f;
    public float maxAngle = 45f;

    private Rigidbody2D rb;
    private float currentAngle = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(pourKey))
        {
            currentAngle += pourSpeed * Time.deltaTime;
            currentAngle = Mathf.Clamp(currentAngle, 0f, maxAngle);
            rb.rotation = currentAngle;
        }
        else
        {
            currentAngle -= pourSpeed * Time.deltaTime;
            currentAngle = Mathf.Clamp(currentAngle, 0f, maxAngle);
            rb.rotation = currentAngle;
        }
    }
}
