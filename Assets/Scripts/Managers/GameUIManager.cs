using UnityEngine;

[RequireComponent(typeof(ButtonController))]
[RequireComponent(typeof(CheckmarkController))]
[RequireComponent(typeof(DropdownController))]
public class GameUIManager : MonoBehaviour
{
        public static GameUIManager Instance { get; private set; }

        public ButtonController P_ButtonController { get; private set; }

        public CheckmarkController P_CheckmarkController { get; private set; }

        public DropdownController P_DropdownController { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;

            DontDestroyOnLoad(gameObject);
        }

    private void Start()
        {
            P_ButtonController = GetComponent<ButtonController>();
            P_CheckmarkController = GetComponent<CheckmarkController>();
            P_DropdownController = GetComponent<DropdownController>();
        }
    }