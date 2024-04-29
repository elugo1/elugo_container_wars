using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container_move : MonoBehaviour
{

    public float speed;
    public Rigidbody2D body;
        private Vector3 originalPosition; // Store the original position of the object
    // Start is called before the first frame update
    void Start()
    {
    originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float xInp = Input.GetAxis("Horizontal");
        float yInp = Input.GetAxis("Vertical");

        // Modify the horizontal velocity based on vertical input
        body.velocity = new Vector2(yInp * speed *2,xInp*speed);    

        if (Time.timeScale == 0f){
            transform.position = new Vector3(1,0,0);
        }
        }
}
