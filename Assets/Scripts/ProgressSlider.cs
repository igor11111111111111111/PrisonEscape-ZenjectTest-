using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ProgressSlider : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [Inject]
    private void Init(GameData data)
    {
        data.Progress.OnValueChanged += Refresh;
    }

    private void Refresh(float normalizedValue)
    {
        _slider.value = normalizedValue;
    }
}
