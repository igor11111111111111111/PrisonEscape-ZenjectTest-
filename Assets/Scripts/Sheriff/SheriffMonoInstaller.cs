using UnityEngine;
using Zenject;

namespace Project
{
    public class SheriffMonoInstaller : UnitMonoInstaller
    {
        public SheriffAI AI => _ai;
        private SheriffAI _ai;

        protected override IController _controller => new SheriffController();

        public override void InstallBindings()
        {
            base.InstallBindings();

            Data();
            AIBinding();
        }

        private void Data()
        {
            var data = new SheriffData();
            Container
                .Bind<SheriffData>()
                .FromInstance(data)
                .AsSingle();
        }

        private void AIBinding()
        {
            _ai = gameObject.AddComponent<SheriffAI>();
            Container.QueueForInject(_ai);
        }
    }
}