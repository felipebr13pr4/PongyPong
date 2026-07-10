using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float m_speed = 2;
    [SerializeField] private BallMovement m_ball;
    private Vector3 m_pretendBallPos = new Vector3(0,0,0);
    private Rigidbody2D m_rigidBody2d;
    private Vector3 m_goToPosition;

    private void Start()
    {
        m_rigidBody2d = GetComponent<Rigidbody2D>();
        StartCoroutine(CalculateGoToPos());
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (m_goToPosition.y >= transform.position.y)
            m_rigidBody2d.linearVelocity = new Vector2(0, 1 * m_speed);
        if (m_goToPosition.y <= transform.position.y)
            m_rigidBody2d.linearVelocity = new Vector2(0, -1 * m_speed);

        if (transform.position.y >= 3.5f)
            m_rigidBody2d.linearVelocity = new Vector2(0, -1 * m_speed);
        if (transform.position.y <= -3.5f)
            m_rigidBody2d.linearVelocity = new Vector2(0, 1 * m_speed);
    }

    IEnumerator CalculateGoToPos()
    {
        while (true)
        {
            m_goToPosition = CalculateBallPos(m_ball.transform.position, m_ball.Direction);
            yield return new WaitForSeconds(3f);
        }
    }

    private Vector2 CalculateBallPos(Vector2 pos, Vector2 dir)
    {
        if (dir == Vector2.zero)
            return pos;

        if (pos.x < -7.5f)
            return pos;

        int safety = 0;

        while (pos.x < 7.4)
        {
            pos += (dir * m_ball.Speed) * 0.1f;

            if (pos.y > 4.5f || pos.y < -4.5f)
                dir.y = -dir.y;

            if (pos.x > 7.5f || pos.x < -7.5f)
                dir.x = -dir.x;

            safety++;
            if (safety > 1000)
            {
                print("Ball Safety Engaged");
                break;
            }
        }

        return pos;
    }
}
