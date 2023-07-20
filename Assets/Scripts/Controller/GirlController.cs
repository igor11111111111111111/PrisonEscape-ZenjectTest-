using UnityEngine;
using Zenject;

namespace Project
{
    public class GirlController : IController
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
                    _animator.Play("Look");
                    transform.position = new Vector3(2.96f, 0f, -2.66f); transform.rotation = Quaternion.Euler(0, -134.7f, 0);
                }
                else
                {
                    _animator.Play("Sit");
                    transform.position = new Vector3(3.72f, 0.155f, -3f); transform.rotation = Quaternion.Euler(0, -166.7f, 0);
                }
            };
        }

    }
}
