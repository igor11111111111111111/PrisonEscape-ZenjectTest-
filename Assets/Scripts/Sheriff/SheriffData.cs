using UnityEngine;

namespace Project
{
    public class SheriffData
    {
        public float MoveSpeed = 0.02f;
        public readonly Vector3[] Targets = new Vector3[]
        {
            new Vector3(-0.54f, 0, 1.03f),
            new Vector3(0, 0, -1),
            new Vector3(1.9f, 0, -3.567f)
        };
    }
}