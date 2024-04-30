using UnityEngine;

public class TriggerHandler : MonoBehaviour
{
    private bool isGamePaused = false;
    public bool p2point = false;
    private int score = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "p2") // Adjust "Target" to match your target object's tag
        {
            // Pause the game
            Time.timeScale = 0f;
            isGamePaused = true;

            // Increment score
            score++;
            p2point = true;

            // Print score (You can replace this with your desired point registration logic)
            Debug.Log("Score: " + score);
            Debug.Log(p2point);
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
        p2point = false;
    }
}

