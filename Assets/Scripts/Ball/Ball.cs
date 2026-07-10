using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class Ball : MonoBehaviour
{
    private BallMovement m_ballMovement;
    private bool m_hasScored = false;
    public static event Action<PaddleType> OnScore;

    private void Start()
    {
        m_ballMovement = GetComponent<BallMovement>();
    }

    private void Update()
    {
        CheckScore();
    }

    private void CheckScore()
    {
        if (m_hasScored) return;

        if (transform.position.x >= 10)
        {
            Score(PaddleType.Player);
        }
        if (transform.position.x <= -10)
        {
            Score(PaddleType.Enemy);
        }
    }

    private void Score(PaddleType type)
    {
        OnScore?.Invoke(type);
        m_hasScored = true;
        StartCoroutine(RepositionBall());
    }

    private IEnumerator RepositionBall()
    {
        yield return new WaitForSeconds(2);
        transform.position = Vector3.zero;
        StartCoroutine(m_ballMovement.RandomStartDirection());
        m_hasScored = false;
    }
}
