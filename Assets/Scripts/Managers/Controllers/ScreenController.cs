using System.Collections;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
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