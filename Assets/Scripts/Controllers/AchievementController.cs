using TMPro;
using UnityEngine;

public class AchievementController : ScoreHandler
{
    private int m_ballHitScreenAmount;
    private int m_paddleHitScreenAmount;

    public int P_BallHitScreenAmount
    { get => m_ballHitScreenAmount;
      set => m_ballHitScreenAmount = value; }
    
    public int P_PaddleHitScreenAmount 
    { get => m_paddleHitScreenAmount;
      set => m_paddleHitScreenAmount = value; }

    public static AchievementController Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
