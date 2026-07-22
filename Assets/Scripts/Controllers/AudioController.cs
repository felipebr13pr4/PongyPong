using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioClip m_ballHitScreen;
    [SerializeField] private AudioClip m_ballScored;
    [SerializeField] private AudioClip m_paddleHit;
    [SerializeField] private AudioClip m_pauseWindowOpen;

    private float m_audioVolume = 1;
    
    private AudioSource m_audioSource;

    public AudioSource P_AudioSource => m_audioSource;
    public float P_AudioVolume => m_audioVolume;

    public static AudioController Instance { get; private set; }
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
        m_audioSource = GetComponent<AudioSource>();
        m_audioVolume = PlayerPrefs.GetFloat("Volume");
    }

    public void PlayAudio(AudioType type)
    {
        m_audioSource.pitch = Random.Range(0.75f, 1.25f);
        switch (type)
        {
            case AudioType.BallHitScreen:
                m_audioSource.PlayOneShot(m_ballHitScreen, m_audioVolume); return;

            case AudioType.BallScored:
                m_audioSource.PlayOneShot(m_ballScored, m_audioVolume); return;

            case AudioType.PaddleHit:
                m_audioSource.PlayOneShot(m_paddleHit, m_audioVolume); return;

            case AudioType.PauseWindowOpen:
                m_audioSource.PlayOneShot(m_pauseWindowOpen, m_audioVolume); return;
        }
    }

    public void SetAudio(float value)
    {
        m_audioVolume = value;
    }
}
