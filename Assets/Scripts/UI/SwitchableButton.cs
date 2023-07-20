using UnityEngine;
using UnityEngine.UI;

namespace Project
{
    public class SwitchableButton : MonoBehaviour
    {
        public Button Button => _button;
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _on;
        [SerializeField] private GameObject _off;
        public bool IsActive => _isActive;
        private bool _isActive;

        private void Awake()
        {
            _isActive = true;
            _button.onClick.AddListener(Switch);
        }

        private void Switch()
        {
            _isActive = !_isActive;
            _on.SetActive(_isActive);
            _off.SetActive(!_isActive);
        }
    } 
}

