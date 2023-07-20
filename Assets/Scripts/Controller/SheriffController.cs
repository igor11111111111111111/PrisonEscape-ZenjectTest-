using UnityEngine;
using Zenject;

namespace Project
{
    public class SheriffController : IController
    {
        private Animator _animator;

        [Inject]
        private void Init(GameData data, Animator animator, Transform transform, DigButton digButton)
        {
            _animator = animator;
            digButton.OnPressed += (active) =>
            {
                if (active)
                {
                    _animator.Play("Dig");
                    transform.position = new Vector3(4.7f, 0.186f, -4.867f); transform.rotation = Quaternion.Euler(-23.29f, -158.66f, 16.58f);
                }
                else
                {
                    _animator.Play("Sit");
                    transform.position = new Vector3(4.2f, 0.29f, -4.53f); transform.rotation = Quaternion.Euler(-12.5f, -196.8f, 15.3f);
                }
            };
        }
    }
}