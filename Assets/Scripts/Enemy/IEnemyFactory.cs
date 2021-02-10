using System;
using UnityEngine;
using static BallLabirynthOOP.CubeTypeBehaviourWrapper;


namespace BallLabirynthOOP
{
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy(BonusType type, CubeTypeBehaviour behaviourType);
    }
}
