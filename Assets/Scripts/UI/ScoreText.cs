using TMPro;

public class ScoreText : ScoreHandler
{
    private TextMeshProUGUI m_TextMeshPro;

    private void Start()
    {
        m_TextMeshPro = GetComponent<TextMeshProUGUI>();
     
        m_TextMeshPro.text = "0 : 0";
    }

    protected override void Score(PaddleType type)
    {
        base.Score(type);

        m_TextMeshPro.text = P_PlayerScore + " : " + P_EnemyScore;
    }
}
