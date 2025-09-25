using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifetime = 3f; // destroys itself after some time

    private void Start()
    {
        // Move the projectile automatically
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.right * speed;

        // Destroy after lifetime seconds to prevent clutter
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollision(collision.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollision(collision.gameObject);
    }

    private void HandleCollision(GameObject other)
    {
        if (other.CompareTag("Breakable"))
        {
            Destroy(other); // destroy the obstacle
            Destroy(gameObject); // destroy the projectile
        }
        // else do nothing for unbreakable obstacles
    }
}
