using UnityEngine;
using Zenject;

namespace Project
{
    public class SheriffMonoInstaller : UnitMonoInstaller
    {
        protected override IController _controller => new SheriffController();

        public override void InstallBindings()
        {
            base.InstallBindings();

            Data();
            AI();
        }

        private void Data()
        {
            var data = new SheriffData();
            Container
                .Bind<SheriffData>()
                .FromInstance(data)
                .AsSingle();
        }

        private void AI()
        {
            SheriffAI ai = gameObject.AddComponent<SheriffAI>();
            Container.QueueForInject(ai);
        }
    }
}