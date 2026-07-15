using UnityEngine;

[RequireComponent(typeof(ButtonController))]
[RequireComponent(typeof(CheckmarkController))]
[RequireComponent(typeof(DropdownController))]
public class GameUIManager : MonoBehaviour
{
        public static GameUIManager Instance { get; private set; }

        public ButtonController ButtonController { get; private set; }

        public CheckmarkController CheckmarkController { get; private set; }

        public DropdownController DropdownController { get; private set; }

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
            ButtonController = GetComponent<ButtonController>();
            CheckmarkController = GetComponent<CheckmarkController>();
            DropdownController = GetComponent<DropdownController>();
        }
    }