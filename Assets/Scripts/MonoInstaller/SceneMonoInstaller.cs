using UnityEngine.UI;
using Zenject;
using UnityEngine;
using System;

namespace Project
{
    public class SceneMonoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            GameData();
            DigHandler();
        }

        private void DigHandler()
        {
            var digHandler = gameObject.AddComponent<DigHandler>();
            Container.QueueForInject(digHandler);
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

