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
                GameManager.Instance.SceneController.LoadScene(SceneType.Game);
                return;

            case ButtonType.Retry:
                GameManager.Instance.SceneController.ReloadScene();
                return;

            case ButtonType.MainMenu:
                GameManager.Instance.SceneController.LoadScene(SceneType.Menu);
                return;

            case ButtonType.Quit:
                PlayerPrefs.SetFloat("Volume",
                                    GameManager.Instance.AudioController.AudioSource.volume);
                PlayerPrefs.Save();
                Application.Quit();
                return;
        }
    }
}