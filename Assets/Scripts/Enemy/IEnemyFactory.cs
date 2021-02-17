using System;
using System.Collections.Generic;
using UnityEngine;


namespace BallLabirynthOOP
{
    public interface IEnemyFactory
    {
        List<IEnemy> AllEnemies { get; }

        IEnemy CreateEnemy(EnemyType type);

        IEnemy FindEnemyModel(EnemyType type, IEnemy enemy);

        void RemoveEnemyModelFromAllEnemiesList(IEnemy enemy);
    }
}
