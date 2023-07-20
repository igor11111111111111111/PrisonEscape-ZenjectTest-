using UnityEngine;
using Zenject;

namespace Project
{
    public abstract class UnitMonoInstaller : MonoInstaller
    {
        protected abstract IController _controller { get;}

        public override void InstallBindings()
        {
            Transform();
            Animator();
            Controller();
        }

        private void Controller()
        {
            Container
                .Bind<IController>()
                .FromInstance(_controller)
                .AsSingle();
            Container.QueueForInject(_controller);
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
