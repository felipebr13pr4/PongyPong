using UnityEngine;

[RequireComponent(typeof(AudioController))]
[RequireComponent(typeof(SceneController))]
[RequireComponent(typeof(GameScreenController))]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public AudioController AudioController { get; private set; }
    
    public SceneController SceneController { get; private set; }

    public GameScreenController GameScreenController { get; private set; }

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
        AudioController = GetComponent<AudioController>();        
        SceneController = GetComponent<SceneController>();
        GameScreenController = GetComponent<GameScreenController>();
    }
}