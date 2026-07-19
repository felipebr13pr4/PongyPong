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
                GameManager.Instance.P_GameScreenController.FullScreen(state);
                return;
        }
    }
}