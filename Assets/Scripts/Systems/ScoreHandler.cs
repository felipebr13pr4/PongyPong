using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    protected int m_playerScore;
    protected int m_enemyScore;

    private void OnEnable()
    {
        Ball.OnScore += Score;
    }

    private void OnDisable()
    {
        Ball.OnScore -= Score;
    }

    protected virtual void Score(PaddleType type)
    {
        if (type == PaddleType.Player)
            m_playerScore += 1;
        if (type == PaddleType.Enemy)
            m_enemyScore += 1;
    }
}