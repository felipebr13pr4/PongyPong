using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private void OnEnable()
    {
        MenuButton.OnButtonTypeClicked += ExecuteAction;
    }

    private void OnDisable()
    {
        MenuButton.OnButtonTypeClicked -= ExecuteAction;
    }

    private void ExecuteAction(ButtonType type)
    {
        switch (type)
        {
            case ButtonType.Start:
                SceneController.Instance.LoadScene(SceneType.Game);
                return;

            case ButtonType.Retry:
                SceneController.Instance.ReloadScene();
                return;

            case ButtonType.MainMenu:
                SceneController.Instance.LoadScene(SceneType.Menu);
                return;

            case ButtonType.Quit:
                SavePlayerPrefs();
                Application.Quit();
                return;

            case ButtonType.SaveSettings:
                SavePlayerPrefs();
                return;
        }
    }

    private void SavePlayerPrefs()
    {
        PlayerPrefs.SetFloat("Volume", AudioController.Instance.P_AudioVolume);
        PlayerPrefs.SetInt("Screen Width", Screen.width);
        PlayerPrefs.SetInt("Screen Height", Screen.height);
        PlayerPrefs.SetInt("Full Screen", Screen.fullScreenMode == FullScreenMode.FullScreenWindow ? 1 : 0);
    }
}