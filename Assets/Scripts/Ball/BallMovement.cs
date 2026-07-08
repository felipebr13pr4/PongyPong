using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float m_speed = 2;
    private Rigidbody2D m_rigidBody2d;
    private int m_verticalDir = 0;
    private int m_horizontalDir = 0;

    private void Start()
    {
        m_rigidBody2d = GetComponent<Rigidbody2D>();

        while (m_verticalDir == 0)
        {
            m_verticalDir = Random.Range(-1, 2);
        }
        while (m_horizontalDir == 0)
        {
            m_horizontalDir = Random.Range(-1, 2);
        }
        print(m_horizontalDir);
        print(m_verticalDir);
    }

    private void Update()
    {
        if (transform.position.y >= 4.5f)
            m_verticalDir = -1;
        if (transform.position.y <= -4.5f)
            m_verticalDir = 1;
    }

    private void FixedUpdate()
    {
        m_rigidBody2d.linearVelocity =
            new Vector2(m_horizontalDir, m_verticalDir).normalized * m_speed;
    }

    private void OnTriggerEnter2D()
    {
        m_horizontalDir = -m_horizontalDir;
    }
}
