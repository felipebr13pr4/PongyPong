using UnityEngine;

[RequireComponent(typeof(AudioController))]
[RequireComponent(typeof(SceneController))]
[RequireComponent(typeof(GameScreenController))]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public AudioController P_AudioController { get; private set; }
    
    public SceneController P_SceneController { get; private set; }

    public GameScreenController p_GameScreenController { get; private set; }

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
        P_AudioController = GetComponent<AudioController>();        
        P_SceneController = GetComponent<SceneController>();
        p_GameScreenController = GetComponent<GameScreenController>();
    }
}