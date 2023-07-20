using UnityEngine;
using Zenject;

namespace Project
{
    public class SheriffMonoInstaller : UnitMonoInstaller
    {
        protected override IController _controller => new SheriffController();
    }
}