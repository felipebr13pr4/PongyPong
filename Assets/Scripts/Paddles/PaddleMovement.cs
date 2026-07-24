using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PaddleMovement : MonoBehaviour
{
    [SerializeField] protected float m_speed = 2;
    protected Rigidbody2D m_rigidBody2d;

    protected virtual void Start()
    {
        m_rigidBody2d = GetComponent<Rigidbody2D>();
    }

    protected virtual void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, ScreenBounds.Bottom+1, ScreenBounds.Top-1);
        transform.position = pos;
    }
}
