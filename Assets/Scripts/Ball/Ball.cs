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

        float outOfScreenRight = 10.5f;
        float outOfScreenLeft = -10.5f;

        if (transform.position.x >= outOfScreenRight)
        {
            Score(PaddleType.Player);
        }
        if (transform.position.x <= outOfScreenLeft)
        {
            Score(PaddleType.Enemy);
        }
    }

    private void Score(PaddleType type)
    {
        OnScore?.Invoke(type);
        m_hasScored = true;
        AudioController.Instance.PlayAudio(AudioType.BallScored);
        StartCoroutine(RepositionBall());
}

    private IEnumerator RepositionBall()
    {
        yield return new WaitForSeconds(0.75f);
        transform.position = Vector3.zero;
        StartCoroutine(m_ballMovement.RandomStartDirection());
        m_hasScored = false;
    }
}
