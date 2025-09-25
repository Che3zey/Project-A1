using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGoal : MonoBehaviour
{
    // Name of your Win scene
    public string winSceneName = "Win Screen";

    // Called when hitting a collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene(winSceneName);
        }
    }

    // Called when entering a trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Goal"))
        {
            SceneManager.LoadScene(winSceneName);
        }
    }
}
