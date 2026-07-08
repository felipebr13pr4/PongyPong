using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_speed = 2;
    private Rigidbody2D m_rigidBody2d;
    private float m_moveDir;
    
    private void Start()
    {
        m_rigidBody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_moveDir = Keyboard.current.wKey.isPressed ? 1 :
                    Keyboard.current.sKey.isPressed ? -1 : 0;
    }

    private void FixedUpdate()
    {
        m_rigidBody2d.linearVelocity = new Vector2(0, m_moveDir * m_speed);
        if (transform.position.y >= 3.5f)
        m_rigidBody2d.linearVelocity = new Vector2(0, -1 * m_speed);
        if (transform.position.y <= -3.5f)
        m_rigidBody2d.linearVelocity = new Vector2(0, 1 * m_speed);
    }
}
