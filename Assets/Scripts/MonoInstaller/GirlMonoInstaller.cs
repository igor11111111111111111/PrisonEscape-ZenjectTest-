using UnityEngine;
using Zenject;

namespace Project
{
    public class GirlMonoInstaller : UnitMonoInstaller
    {
        public override void InstallBindings()
        {
            base.InstallBindings();
            Controller();
        }

        private void Controller()
        {
            var controller = new GirlController();
            Container
                .Bind<GirlController>()
                .FromInstance(controller)
                .AsSingle();
            Container.QueueForInject(controller);
        }
    }
}
