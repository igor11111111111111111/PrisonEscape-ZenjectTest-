using UnityEngine;
using Zenject;

namespace Project
{
    public class DigHandler : MonoBehaviour
    {
        private GameData _data;
        private bool _isDigActive;

        [Inject]
        private void Init(DigButton digButton, GameData data)
        {
            _data = data;
            digButton.OnPressed += (active) => _isDigActive = active;
        }

        private void Update()
        {
            if (!_isDigActive) return;

            _data.Progress.Change();
        }
    }
}

