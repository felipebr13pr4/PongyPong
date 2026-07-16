using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SaveSettingsButton : MonoBehaviour
{
    private Button m_button;

    private void Awake()
    {
        m_button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        m_button.onClick.AddListener(SavePrefs);
    }

    private void OnDisable()
    {
        m_button.onClick.RemoveListener(SavePrefs);
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetFloat("Volume", GameManager.Instance.AudioController.AudioVolume);
        PlayerPrefs.SetInt("Screen Width", Screen.width);
        PlayerPrefs.SetInt("Screen Height", Screen.height);
        PlayerPrefs.SetInt("Full Screen", Screen.fullScreenMode == FullScreenMode.FullScreenWindow ? 1 : 0);
    }
}
