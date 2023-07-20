using UnityEngine;
using Zenject;

namespace Project
{
    public class GirlMonoInstaller : UnitMonoInstaller
    {
        protected override IController _controller => new GirlController();
    }
}
