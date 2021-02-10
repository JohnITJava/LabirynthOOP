using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class EnemyProvider : IEnemy
    {
        public event Action<int> OnTriggerEnterChange = delegate { };


        public void Move(Vector3 point)
        {
            throw new NotImplementedException();
        }
    }
}
