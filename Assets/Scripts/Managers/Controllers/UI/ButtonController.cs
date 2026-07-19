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
                GameManager.Instance.P_SceneController.LoadScene(SceneType.Game);
                return;

            case ButtonType.Retry:
                GameManager.Instance.P_SceneController.ReloadScene();
                return;

            case ButtonType.MainMenu:
                GameManager.Instance.P_SceneController.LoadScene(SceneType.Menu);
                return;

            case ButtonType.Quit:
                PlayerPrefs.SetFloat("Volume",
                                    GameManager.Instance.P_AudioController.P_AudioSource.volume);
                PlayerPrefs.Save();
                Application.Quit();
                return;
        }
    }
}