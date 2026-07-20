using UnityEngine;

public class CheckmarkController : MonoBehaviour
{
    private void OnEnable()
    {
        MenuCheckmark.OnCheckmark += ExecuteAction;
    }

    private void OnDisable()
    {
        MenuCheckmark.OnCheckmark -= ExecuteAction;
    }

    private void ExecuteAction(CheckmarkType type, bool state)
    {
        switch (type)
        {
            case CheckmarkType.Fullscreen:
                GameScreenController.Instance.FullScreen(state);
                return;
        }
    }
}