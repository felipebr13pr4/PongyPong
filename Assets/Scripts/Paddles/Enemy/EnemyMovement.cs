using System.Collections;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class EnemyMovement : PaddleMovement
{
    [SerializeField] private BallMovement m_ball;
    private Vector3 m_goToPosition;

    private new void Start()
    {
        base.Start();
        StartCoroutine(CalculateGoToPos());
    }

    private new void FixedUpdate()
    {
        if (m_goToPosition.y >= transform.position.y)
            m_rigidBody2d.linearVelocity = new Vector2(0, 1 * m_speed);
        if (m_goToPosition.y <= transform.position.y)
            m_rigidBody2d.linearVelocity = new Vector2(0, -1 * m_speed);

        base.FixedUpdate();
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
