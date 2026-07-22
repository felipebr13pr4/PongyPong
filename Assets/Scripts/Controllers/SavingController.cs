using System.Collections;
using UnityEngine;

public class SavingController : MonoBehaviour
{
    private bool m_isAutoSaveOn = true;

    public static SavingController Instance { get; private set; }
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
        StartCoroutine(AutoSave());
    }

    private IEnumerator AutoSave()
    {   
        yield return new WaitForSecondsRealtime(15);
        if (!m_isAutoSaveOn) yield break;
        Save();
    }

    public void SaveAll()
    {
        Save();
        SavePlayerPrefs();
    }
    
    private void Save()
    {
        PlayerPrefs.SetInt("Player Score", GameStatsController.Instance.P_PlayerScore);
        PlayerPrefs.SetInt("Enemy Score", GameStatsController.Instance.P_EnemyScore);
        PlayerPrefs.SetInt("Paddle Hits", GameStatsController.Instance.P_PaddleHitScreenAmount);
        PlayerPrefs.SetInt("Ball Hits", GameStatsController.Instance.P_BallHitScreenAmount);
        PlayerPrefs.SetFloat("Difficulty", GameStatsController.Instance.P_EnemyDifficulty);
    }

    private void SavePlayerPrefs()
    {
        PlayerPrefs.SetFloat("Volume", AudioController.Instance.P_AudioVolume);
        PlayerPrefs.SetInt("Screen Width", Screen.width);
        PlayerPrefs.SetInt("Screen Height", Screen.height);
        PlayerPrefs.SetInt("Full Screen", Screen.fullScreenMode == FullScreenMode.FullScreenWindow ? 1 : 0);
    }
}
