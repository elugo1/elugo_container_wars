using UnityEngine;

public class TriggerHandler2 : MonoBehaviour
{
    private bool isGamePaused = false;
    public bool p1point = true;
    private int scorep2 = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "p1") // Adjust "Target" to match your target object's tag
        {
            // Pause the game
            Time.timeScale = 0f;
            isGamePaused = true;

            // Increment score
            scorep2++;
            p1point = true;

            // Print score (You can replace this with your desired point registration logic)
            Debug.Log("Score P2s: " + scorep2);
        }
    }

    void Update()
    {
        // Check if game is paused and listen for input to resume
        if (isGamePaused && Input.GetKeyDown(KeyCode.Space)) // Adjust the key to your desired input
        {
            ResumeGame();
        }
    }

    void ResumeGame()
    {
        // Resume the game
        Time.timeScale = 1f;
        isGamePaused = false;
        p1point = false;
    }
}

