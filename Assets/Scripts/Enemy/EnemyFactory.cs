using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class EnemyFactory : IEnemyFactory
    {
        private readonly EnemyData _data;
        private GameObject _enemiesBox;

        private int _enemyCubeCounter = 0;

        public EnemyFactory(EnemyData data)
        {
            _enemiesBox = new GameObject("Enemies");
            _data = data;
        }

        public IEnemy CreateEnemy(EnemyType type)
        {
            IEnemy enemyModel = null;

            var enemy = _data.GetEnemy(type).EnemyPrefab();

            if (type is EnemyType.Cube)
            {
                var bonusCubeObj = Object.Instantiate(enemy, Positions.BonusPositions[_enemyCubeCounter++], Quaternion.identity, _enemiesBox.transform);
                BonusCube bonusCube = new BonusCube(bonusCubeObj);
                enemyModel = new BonusCubeModel(bonusCube);
            }

            return enemyModel;
        }
    }
}
