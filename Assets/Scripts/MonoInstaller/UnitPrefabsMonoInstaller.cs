using UnityEngine;
using Zenject;

namespace Project
{
    public class UnitPrefabsMonoInstaller : MonoInstaller
    {
        [SerializeField]
        public PlayerMonoInstaller PlayerPrefab;
        [SerializeField]
        public GirlMonoInstaller GirlPrefab;
        [SerializeField]
        public SheriffMonoInstaller SheriffPrefab;

        public override void InstallBindings()
        {
            Sheriff();
            Player();
            Girl();
        }

        private void Girl()
        {
            var girl = Container.InstantiatePrefabForComponent<GirlMonoInstaller>(GirlPrefab, new Vector3(3.72f, 0.155f, -3f), Quaternion.Euler(0, -166.7f, 0), null);
        }

        private void Player()
        {
            var player = Container.InstantiatePrefabForComponent<PlayerMonoInstaller>(PlayerPrefab, new Vector3(4.2f, 0.29f, -4.53f), Quaternion.Euler(-12.5f, -196.8f, 15.3f), null);
        }

        private void Sheriff()
        {
            var sheriff = Container.InstantiatePrefabForComponent<SheriffMonoInstaller>(SheriffPrefab, new Vector3(-0.54f, 0, 1.03f), Quaternion.Euler(0, 0, 0), null);

            Container
                .Bind<SheriffAI>()
                .FromInstance(sheriff.AI)
                .AsSingle();
        }
    }
}