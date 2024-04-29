
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cable_move_1 : MonoBehaviour
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
        float xInp = Input.GetAxis("Horizontal");
        float yInp = Input.GetAxis("Vertical");

        // Modify the horizontal velocity based on vertical input
        body.velocity = new Vector2(yInp * speed *2,0);    
        
        }
}
