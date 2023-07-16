using UnityEngine;
using Zenject;

namespace Project
{
    public class UnitMonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Transform();
            Animator();
        }

        private void Transform()
        {
            Container
                .Bind<Transform>()
                .FromInstance(transform)
                .AsSingle();
        }

        private void Animator()
        {
            Container
                .Bind<Animator>()
                .FromInstance(GetComponent<Animator>())
                .AsSingle();
        }
    }
}
