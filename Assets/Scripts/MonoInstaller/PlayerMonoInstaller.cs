using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerMonoInstaller : UnitMonoInstaller
    {
        public override void InstallBindings()
        {
            base.InstallBindings();
            Controller();
        }

        private void Controller()
        {
            var controller = new PlayerController();
            Container
                .Bind<PlayerController>()
                .FromInstance(controller)
                .AsSingle();
            Container.QueueForInject(controller);
        }
    }
}
