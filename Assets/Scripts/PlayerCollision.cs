using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Breakable"))
        {
            SceneManager.LoadScene("Game Over"); // exact name of your Game Over scene
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle") || collision.CompareTag("Breakable"))
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
