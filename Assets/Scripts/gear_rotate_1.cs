using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear_rotate_1 : MonoBehaviour
{
    public Rigidbody2D body;
    public float rotationSpeed = 5f;

    void Start()
    {
        // Get the Rigidbody component attached to the object
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get the velocity of the object along the y-axis
        float velocityY = Input.GetAxis("Vertical");

        // Calculate rotation angle based on velocity
        float rotationAngle = velocityY * rotationSpeed * Time.deltaTime;

        // Apply rotation around the z-axis
        transform.Rotate(0f, 0f, rotationAngle);
    }
}