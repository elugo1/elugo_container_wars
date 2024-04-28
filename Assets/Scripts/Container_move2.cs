using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container_move2 : MonoBehaviour
{

    public float speed;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInp = Input.GetAxis("Horizontal1");
        float yInp = Input.GetAxis("Vertical1");

        // Modify the horizontal velocity based on vertical input
        body.velocity = new Vector2(-1*yInp * speed*2,xInp*speed);    
    }
}
