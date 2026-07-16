using System;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Dropdown))]
public class MenuDropdown : MonoBehaviour
{
    [SerializeField] private DropdownType m_dropdownType;
    private TMP_Dropdown m_dropdownComponent;
    public static event Action<DropdownType, int, string> OnDropdown;

    private void Awake()
    {
        m_dropdownComponent = GetComponent<TMP_Dropdown>();
    }

    private void Start()
    {
        initialState();
    }

    private void OnEnable()
    {
        m_dropdownComponent.onValueChanged.AddListener(DropdownChanged);
    }

    private void OnDisable()
    {
        m_dropdownComponent.onValueChanged.RemoveListener(DropdownChanged);
    }

    private void DropdownChanged(int index)
    {
        string optionName = m_dropdownComponent.options[index].text;
        OnDropdown?.Invoke(m_dropdownType, index, optionName);
    }


    private void initialState()
    {
        switch (m_dropdownType)
        {
            case DropdownType.ScreenRes:
                m_dropdownComponent.value = Screen.width == 1920 ? 0 :
                                            Screen.width == 1280 ? 1 : 2;
                return;
        }
    }
}