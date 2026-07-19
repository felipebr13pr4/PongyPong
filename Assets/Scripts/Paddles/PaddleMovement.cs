using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PaddleMovement : MonoBehaviour
{
    [SerializeField] protected float m_speed = 2;
    protected Rigidbody2D m_rigidBody2d;

    protected void Start()
    {
        m_rigidBody2d = GetComponent<Rigidbody2D>();
    }

    protected void FixedUpdate()
    {
        float maxTopInScreen = 4.1f;
        float maxBottomInScreen = -4.1f;

        if (transform.position.y >= maxTopInScreen)
            m_rigidBody2d.linearVelocity = new Vector2(0, Vector2.down.y * m_speed);
        if (transform.position.y <= maxBottomInScreen)
            m_rigidBody2d.linearVelocity = new Vector2(0, Vector2.up.y * m_speed);
    }
}
