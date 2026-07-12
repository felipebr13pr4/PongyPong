using UnityEngine;

[RequireComponent(typeof(SoundController))]
[RequireComponent(typeof(SceneController))]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public SoundController SoundController { get; private set; }
    public SceneController SceneController { get; private set; }

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
        SoundController = GetComponent<SoundController>();        
        SceneController = GetComponent<SceneController>();
    }
}