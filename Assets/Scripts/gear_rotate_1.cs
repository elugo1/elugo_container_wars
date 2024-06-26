using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear_rotate_1 : MonoBehaviour
{
    public Transform targetObject; // Reference to the GameObject whose x-value you want to reference


    void Start()
    {
        // Get the Rigidbody component attached to the object
    }

    void Update()
    {
    // Check if the targetObject is not null
        if (targetObject != null)
        {
            // Set the x-position of this GameObject to be the same as the x-position of the targetObject
            transform.localRotation = Quaternion.Euler(new Vector3(0,0, targetObject.position.y*100));
        }
        else
        {
            Debug.LogWarning("Target object is null. Please assign a GameObject to targetObject variable.");
        }
    }
}