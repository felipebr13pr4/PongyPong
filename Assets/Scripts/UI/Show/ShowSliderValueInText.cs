using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowSliderValueInText : MonoBehaviour
{
    [SerializeField] private SliderType m_sliderType;
    private TextMeshProUGUI m_TextMeshPro;

    void Start()
    {
        m_TextMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ChangeText();
    }

    private void ChangeText()
    {
        float value = m_sliderType switch
        {
            SliderType.Volume => GameManager.Instance.SoundController.CalculateVolumePercentage(),
            _ => GameManager.Instance.SoundController.AudioVolume
        };
        string strLenght = m_sliderType switch
        {
            SliderType.Volume => "F0",
            _ => "F0"
        };
        string str = m_sliderType switch
        {
            SliderType.Volume => "%",
            _ => ""
        };
        m_TextMeshPro.text = value.ToString(strLenght) + str;
    }

}