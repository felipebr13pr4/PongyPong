using UnityEngine;

public class DropdownController : MonoBehaviour
{
    private void OnEnable()
    {
        MenuDropdown.OnDropdown += ExecuteAction;
    }

    private void OnDisable()
    {
        MenuDropdown.OnDropdown -= ExecuteAction;
    }

    private void ExecuteAction(DropdownType type, int index, string optionName)
    {
        switch (type)
        {
            case DropdownType.ScreenRes:
                HandleScreenResDropdown(index, optionName);
                return;
        }
    }

    private void HandleScreenResDropdown(int index, string optionName)
    {
        switch (index)
        {
            case 0:
                if (optionName != "1920x1080") return;
                StartCoroutine(
                    GameManager.Instance.ScreenController.ChangeScreenResolution(1920, 1080));
                return;
            case 1:
                if (optionName != "1280x720") return;
                StartCoroutine(
                    GameManager.Instance.ScreenController.ChangeScreenResolution(1280, 720));
                return;
            case 2:
                if (optionName != "960x540") return;
                StartCoroutine(
                    GameManager.Instance.ScreenController.ChangeScreenResolution(960, 540));
                return;
        }
    }
}