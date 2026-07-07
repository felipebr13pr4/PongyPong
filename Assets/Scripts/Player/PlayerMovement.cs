using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float m_speed = 2;
    private Rigidbody2D m_rigidbody;
    private float m_moveDir;
    
    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        m_moveDir = Keyboard.current.wKey.wasPressedThisFrame ? 1 :
                    Keyboard.current.sKey.wasPressedThisFrame ? -1 : m_moveDir;

        m_rigidbody.linearVelocity = new Vector2(0, m_moveDir * m_speed);

        m_moveDir = Keyboard.current.wKey.wasReleasedThisFrame ? 0 :
                    Keyboard.current.sKey.wasReleasedThisFrame ? 0 : m_moveDir;

    }

    private void FixedUpdate()
    {
        if (transform.position.y >= 3.5f)
            m_moveDir = -1;
        if (transform.position.y <= -3.5f)
            m_moveDir = 1;
    }
}
