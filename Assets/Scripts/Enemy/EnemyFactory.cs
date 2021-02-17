using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class EnemyFactory : IEnemyFactory
    {
        private readonly EnemyData _data;
        private GameObject _enemiesBox;

        private List<IEnemy> _allEnemiesModels;

        private int _enemyCubeCounter = 0;

        
        public EnemyFactory(EnemyData data)
        {
            _allEnemiesModels = new List<IEnemy>();
            _enemiesBox = new GameObject("Enemies");
            _data = data;
        }

        public List<IEnemy> AllEnemies => _allEnemiesModels;

        public IEnemy CreateEnemy(EnemyType type)
        {
            IEnemy enemyModel = null;

            var enemy = _data.GetEnemy(type).EnemyPrefab();

            if (type is EnemyType.Cube)
            {
                var bonusCubeObj = Object.Instantiate(enemy, Positions.BonusPositions[_enemyCubeCounter++], Quaternion.identity, _enemiesBox.transform);
                BonusCube bonusCube = new BonusCube(bonusCubeObj);
                enemyModel = new BonusCubeModel(bonusCube);
                _allEnemiesModels.Add(enemyModel);
            }

            return enemyModel;
        }

        public IEnemy FindEnemyModel(EnemyType type, IEnemy enemy)
        {
            IEnemy enemyAsModel = null;

            if (type is EnemyType.Cube)
            {
                var bco = (BonusCube)enemy;
                var bcm = _allEnemiesModels
                    .Where(em => em is BonusCubeModel)
                    .Cast<BonusCubeModel>()
                    .ToList();

                enemyAsModel = bcm.FirstOrDefault(bm => bm.BonusCube.Equals(bco));
            }

            return enemyAsModel;
        }

        public void RemoveEnemyModelFromAllEnemiesList(IEnemy enemy)
        {
            _allEnemiesModels.Remove(enemy);
        }
    }
}
