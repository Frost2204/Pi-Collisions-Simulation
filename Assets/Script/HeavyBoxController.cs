using UnityEngine;

public class HeavyBoxController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 1f;
        rb.gravityScale = 0f;
        rb.linearDamping = 0;
        rb.angularDamping = 0;
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.freezeRotation = true;
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    public void SetMass(float newMass)
    {
        rb.mass = newMass;
    }

    public float GetMass()
    {
        return rb.mass;
    }

    public void SetVelocity(float newVelocity)
    {
        rb.linearVelocity = new Vector2(newVelocity, 0); // ✅ Fixed incorrect property
    }

    public float GetVelocity()
    {
        return rb.linearVelocity.x;
    }
}
