using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear_rotate_2 : MonoBehaviour
{
    // Start is called before the first frame update
        public Transform targetObject; // Reference to the GameObject whose x-value you want to reference

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targetObject != null)
         {
            // Set the x-position of this GameObject to be the same as the x-position of the targetObject
            transform.localRotation = Quaternion.Euler(new Vector3(0,0,-1* targetObject.position.y*100));
        }
        else
        {
            Debug.LogWarning("Target object is null. Please assign a GameObject to targetObject variable.");
        } 
    }
}
