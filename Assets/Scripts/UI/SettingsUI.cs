using UnityEngine;
using UnityEngine.UI;

namespace Project
{
    public class SettingsUI : MonoBehaviour
    {
        [SerializeField]
        private SwitchableButton _sound;
        [SerializeField]
        private SwitchableButton _music;
        [SerializeField]
        private Button _activator;
        [SerializeField]
        private GameObject _parent;

        private void Awake()
        {
            _activator.onClick.AddListener(
                () => _parent.SetActive(!_parent.activeInHierarchy));
        }
    }
}

