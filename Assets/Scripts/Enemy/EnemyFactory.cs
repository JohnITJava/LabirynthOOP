using System;
using UnityEngine;
using static BallLabirynthOOP.CubeTypeBehaviourWrapper;


namespace BallLabirynthOOP
{
    public sealed class EnemyFactory : IEnemyFactory
    {
        private readonly BonusCubeData _data;

        public EnemyFactory(BonusCubeData data)
        {
            _data = data;
        }

        public IEnemy CreateEnemy(BonusType bonusType, CubeTypeBehaviour typeBehaviour)
        {
            return new EnemyProvider();
        }
    }
}
