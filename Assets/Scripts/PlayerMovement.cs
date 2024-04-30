using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.XR;

public class PlayerMovement : MonoBehaviour
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
        // float xInp = Input.GetAxis("Horizontal");
        float yInp = Input.GetAxis("Vertical");


        // if(Mathf.Abs(xInp)>0){
        //     body.velocity = new Vector2(xInp *speed, body.velocity.y);
        // }
        if (Mathf.Abs(yInp)>0){
            body.velocity = new Vector2(body.velocity.x,yInp *speed);
        }
                if (Time.timeScale == 0f){
            transform.position = new Vector3(2.57f,0.2f,0);
        }
    }
}
