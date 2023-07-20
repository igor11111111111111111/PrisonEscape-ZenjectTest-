using UnityEngine;
using Zenject;

namespace Project
{
    public class GirlController : IController
    {
        private Animator _animator;
        private Transform _transform;
        private enum State
        {
            Look,
            Sit
        }
        private State _state;

        [Inject]
        private void Init(GameData data, Animator animator, Transform transform, DigButton digButton, SheriffAI sheriffAI)
        {
            _animator = animator;
            _transform = transform;
            _state = State.Sit;

            digButton.OnPressed += DigButtonPressedHandler;
            sheriffAI.OnStartCheck += SheriffCheckHandler;
        }

        private void DigButtonPressedHandler(bool active)
        {
            if (active)
            {
                _state = State.Look;
                _animator.Play("Look");
                _transform.position = new Vector3(2.96f, 0f, -2.66f); 
                _transform.rotation = Quaternion.Euler(0, -134.7f, 0);
            }
            else
            {
                _state = State.Sit;
                _animator.Play("Sit");
                _transform.position = new Vector3(3.72f, 0.155f, -3f);   
                _transform.rotation = Quaternion.Euler(0, -166.7f, 0);
            }
        }

        private void SheriffCheckHandler()
        {
            if(_state == State.Look)
            {
                _animator.Play("Signal");
            }
        }
    }
}
