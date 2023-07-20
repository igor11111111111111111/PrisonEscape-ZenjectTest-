using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class ProgressSlider : MonoBehaviour
    {
        private Slider _slider;

        [Inject]
        private void Init(GameData data)
        {
            _slider = GetComponent<Slider>();
            data.Progress.OnValueChanged += Refresh;
        }

        private void Refresh(float normalizedValue)
        {
            _slider.value = normalizedValue;
        }
    }
}

