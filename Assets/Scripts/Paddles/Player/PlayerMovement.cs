using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : PaddleMovement
{
    private float m_moveDir;
    
    private void Update()
    {
        m_moveDir = Keyboard.current.wKey.isPressed ? 1 :
                    Keyboard.current.sKey.isPressed ? -1 : 0;
    }

    protected override void FixedUpdate()
    {
        m_rigidBody2d.linearVelocity = new Vector2(0, m_moveDir * m_speed);

        base.FixedUpdate();
    }
}
