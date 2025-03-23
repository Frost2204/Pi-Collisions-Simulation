using UnityEngine;

public class SmallBoxController : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on " + gameObject.name);
            return;
        }

        rb.mass = 1f;
        rb.gravityScale = 0f;
        rb.linearDamping = 0;
        rb.angularDamping = 0;
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.freezeRotation = true;
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;

        gameManager = FindObjectOfType<GameManager>();
    }

    public void SetVelocity(float newVelocity)
    {
        if (rb != null)
        {
            rb.linearVelocity = new Vector2(newVelocity, 0); // ✅ Fixed incorrect property
        }
    }

    public float GetVelocity()
    {
        return rb != null ? rb.linearVelocity.x : 0f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("HeavyBox") || collision.gameObject.CompareTag("Wall"))
        {
            gameManager.RegisterCollision();
        }
    }
}
