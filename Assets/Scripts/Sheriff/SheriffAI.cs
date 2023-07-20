using System;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Project
{
    public class SheriffAI : MonoBehaviour
    {
        private Animator _animator;
        private SheriffData _data;
        public Action OnStartCheck;

        [Inject]
        private void Init(SheriffData data, Animator animator)
        {
            _animator = animator;
            _data = data;
        }

        private async void Awake()
        {
            while (this != null)
            {
                await Task.Delay(3000);
                OnStartCheck?.Invoke();
                Animation(true);
                await Move(1);
                await Move(2);
                Animation(false);

                await Task.Delay(2000);
                Animation(true);
                await Move(1);
                await Move(0);
                Animation(false);
            }
        }

        private async Task Move(int index)
        {
            var target = _data.Targets[index];
            while (this != null && transform.position != target)
            {
                transform.position = Vector3.MoveTowards(transform.position, target, _data.MoveSpeed);
                transform.LookAt(target);
                await Task.Delay(10);
            }
        }

        private void Animation(bool active)
        {
            if(this != null)
                _animator.SetBool("IsWalk", active);
        }
    }
}