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
            m_goToPosition = CalculateBallPos(m_ball.transform.position, m_ball.P_Direction);
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

        float xRightLimit = 7.5f;
        float xLeftLimit = -7.5f;

        float yUpLimit = 5.1f;
        float yDownLimit = -5.1f;

        while (pos.x < xRightLimit)
        {
            pos += (dir * m_ball.P_Speed) * 0.1f;

            if (pos.y > yUpLimit || pos.y < yDownLimit)
                dir.y = -dir.y;

            if (pos.x > xRightLimit || pos.x < xLeftLimit)
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
