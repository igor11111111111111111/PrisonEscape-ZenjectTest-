using UnityEngine.UI;
using Zenject;
using UnityEngine;
using System;

namespace Project
{
    public class SceneMonoInstaller : MonoInstaller
    {
        public DigButton DigButton;
        public Slider Progress;
        public PlayerMonoInstaller PlayerPrefab;
        public GirlMonoInstaller GirlPrefab;
        public SheriffMonoInstaller SheriffPrefab;

        public override void InstallBindings()
        {
            DigButtonBind();
            ProgressSlider();
            GameData();
            DigHandler();
            Player();
            Girl();
            Sheriff();
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
        }

        private void DigHandler()
        {
            var digHandler = gameObject.AddComponent<DigHandler>();
            Container.QueueForInject(digHandler);
        }

        private void DigButtonBind()
        {
            Container
                .Bind<DigButton>()
                .FromInstance(DigButton)
                .AsSingle();
        }

        private void ProgressSlider()
        {
            Container
                .Bind<Slider>()
                .FromInstance(Progress)
                .AsSingle();
        }

        private void GameData()
        {
            Progress progress = new Progress(100, 0.1f);
            GameData data = new GameData(progress);
            Container
                .Bind<GameData>()
                .FromInstance(data)
                .AsSingle();
        }
    }
}

