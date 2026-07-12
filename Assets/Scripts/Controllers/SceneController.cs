using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Update()
    {
        // Temporary, for testing purposes.
        if (Keyboard.current.rKey.wasPressedThisFrame)
            ReloadScene();
    }

    public void LoadScene(SceneType type)
    {
        string sceneToLoad = type switch
        {
            SceneType.Game => "MainGame",
            SceneType.Menu => "MainMenu",
            _ => "MainMenu",
        };

        SceneManager.LoadScene(sceneToLoad);
    }

    public void ReloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
