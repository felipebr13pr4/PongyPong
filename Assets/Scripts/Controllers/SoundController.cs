using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioClip m_ballHitScreen;
    [SerializeField] private AudioClip m_ballScored;
    [SerializeField] private AudioClip m_paddleHit;
    [SerializeField] private AudioClip m_pauseWindowOpen;

    private float m_audioVolume = 1;
    
    private AudioSource m_audioSource;

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio(AudioType type)
    {
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

}
