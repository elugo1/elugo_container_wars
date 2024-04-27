using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cable_move : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetObject; // Reference to the GameObject whose x-value you want to reference
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the targetObject is not null
        if (targetObject != null)
        {
            // Set the x-position of this GameObject to be the same as the x-position of the targetObject
            transform.position = new Vector3(targetObject.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            Debug.LogWarning("Target object is null. Please assign a GameObject to targetObject variable.");
        }
    }
}

