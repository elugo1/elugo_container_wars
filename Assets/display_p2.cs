using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display_p2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player_1_person; // Reference to GameObject A
    // public GameObject p2_point_gain;
    private SpriteRenderer sprite2Renderer;

    void Start()
    {
        sprite2Renderer = GetComponent<SpriteRenderer>();
        sprite2Renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player_1_person != null)
        {
            // Access ScriptA on GameObject A and read the bool
            bool boolValue = player_1_person.GetComponent<TriggerHandler>().p2point;
            if (Time.timeScale == 0f && boolValue){
                sprite2Renderer.enabled = true;
            }
            else{
                 sprite2Renderer.enabled = false;
            }
        }
    }
}
