using UnityEngine;

public class GameStatsController : ScoreHandler
{
    private int m_ballHitScreenAmount;
    private int m_paddleHitScreenAmount;
    private float m_enemyDifficulty;

    public int P_BallHitScreenAmount
    { get => m_ballHitScreenAmount;
      set => m_ballHitScreenAmount = value; }
    
    public int P_PaddleHitScreenAmount 
    { get => m_paddleHitScreenAmount;
      set => m_paddleHitScreenAmount = value; }

    public float P_EnemyDifficulty
    { get => m_enemyDifficulty;
        set => m_enemyDifficulty = value; }

    public static GameStatsController Instance { get; private set; }
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

    private void Start()
    {
        m_playerScore = PlayerPrefs.GetInt("Player Score");
        m_enemyScore = PlayerPrefs.GetInt("Enemy Score");
        m_paddleHitScreenAmount = PlayerPrefs.GetInt("Paddle Hits");
        m_ballHitScreenAmount = PlayerPrefs.GetInt("Ball Hits");
        m_enemyDifficulty = PlayerPrefs.GetInt("Difficulty");

        if (m_enemyDifficulty == 0) m_enemyDifficulty = 3;
    }
}
