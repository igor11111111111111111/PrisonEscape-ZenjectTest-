using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{

    public class UIMonoInstaller : MonoInstaller
    {
        [SerializeField]
        public DigButton DigButton;
        [SerializeField]
        public Slider Progress;

        public override void InstallBindings()
        {
            DigButtonBind();
            ProgressSlider();
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
    }
}

