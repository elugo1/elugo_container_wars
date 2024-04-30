using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display_p1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player_2_person; // Reference to GameObject A
    // public GameObject p1_point_gain;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player_2_person != null)
        {
            // Access ScriptA on GameObject A and read the bool
            bool boolValue = player_2_person.GetComponent<TriggerHandler2>().p1point;
            if (Time.timeScale == 0f && boolValue == true){
                spriteRenderer.enabled = true ;
            }
            else{
                spriteRenderer.enabled = false;
            }
        }
    }
}
