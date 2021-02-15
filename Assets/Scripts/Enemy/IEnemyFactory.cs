using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy(EnemyType type);
    }
}
