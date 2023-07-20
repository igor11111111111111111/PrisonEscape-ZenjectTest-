using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerMonoInstaller : UnitMonoInstaller
    {
        protected override IController _controller => new PlayerController();
    }
}
