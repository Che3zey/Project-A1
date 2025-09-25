using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float verticalSpeed = 5f;
    public float minY = -5f;
    public float maxY = 5f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");

        // Calculate new Y position and clamp it
        float newY = Mathf.Clamp(rb.position.y + vertical * verticalSpeed * Time.fixedDeltaTime, minY, maxY);

        // Move player forward and use clamped Y
        Vector2 newPosition = new Vector2(rb.position.x + forwardSpeed * Time.fixedDeltaTime, newY);

        rb.MovePosition(newPosition);
    }
}
