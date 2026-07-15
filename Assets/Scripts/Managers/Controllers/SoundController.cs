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

    public AudioSource AudioSource => m_audioSource;
    public float AudioVolume => m_audioVolume;

    private void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        MenuSlider.OnSliderChangedByType += AudioChange;
    }

    private void OnDisable()
    {
        MenuSlider.OnSliderChangedByType -= AudioChange;
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

    public void AudioChange(SliderType type, float value)
    {
        if (type != SliderType.Volume) return;
        m_audioVolume = value;
    }

    public int CalculateVolumePercentage()
    {
        int volume = (int)(m_audioVolume * 100);
        return volume;
    }
}
