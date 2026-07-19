using System.Collections;
using UnityEngine;

public class GameScreenController : MonoBehaviour
{
    private void Start()
    {
        bool fullScreen = PlayerPrefs.GetInt("Full Screen") != 0;
        FullScreen(fullScreen);
        int width = PlayerPrefs.GetInt("Screen Width");
        int height = PlayerPrefs.GetInt("Screen Height");
        ChangeScreenResolution(width, height);
    }

    public void FullScreen(bool state)
    {
        Screen.fullScreenMode = state ? FullScreenMode.FullScreenWindow : FullScreenMode.Windowed;
    }

    public IEnumerator ChangeScreenResolution(int x, int y)
    {
        yield return null;
        Screen.SetResolution(x, y, Screen.fullScreenMode);
    }
}