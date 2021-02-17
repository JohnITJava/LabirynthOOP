using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class EnemyInitializator : IInizialization
    {
        private readonly IEnemyFactory _enemyFactory;

        private CompositeMove _cubeCompositeGroup;
        private CameraData _cameraData;
        private List<IEnemy> _enemies;


        public EnemyInitializator(ControllersExecutor controllerExecutor, IEnemyFactory factory, CameraData cameraData)
        {
            _cameraData = cameraData;
            _enemies = new List<IEnemy>();

            _enemyFactory = factory;
            _cubeCompositeGroup = new CompositeMove();

            for (int i = 0; i < Positions.BonusPositions.Count; i++)
            {
                var enemy = _enemyFactory.CreateEnemy(EnemyType.Cube);
                _cubeCompositeGroup.AddUnit(enemy);
                _enemies.Add(enemy);

                var bcm = enemy as BonusCubeModel;

                bcm.BonusCube.EnemyOnDestroyChange += OnDestroyChange;
            }

            controllerExecutor.Add(new EnemyMoveController(_cubeCompositeGroup));
            controllerExecutor.Add(this);
        }

        public void Initialization() { }

        public IEnemyMove GetMoveEnemies()
        {
            return _cubeCompositeGroup;
        }

        public IEnumerable<IEnemy> GetEnemies()
        {
            foreach (var enemy in _enemies)
            {
                yield return enemy;
            }
        }

        private void OnDestroyChange(IEnemy enemy)
        {
            IEnemy modelCube = _enemyFactory.FindEnemyModel(EnemyType.Cube, enemy);
            var cube = (BonusCube)enemy;

            _cameraData.CameraView.Player.EventSignersInvoke(cube);

            _enemyFactory.RemoveEnemyModelFromAllEnemiesList(modelCube);
            _cubeCompositeGroup.RemoveUnit(modelCube);
            _enemies.Remove(modelCube);

            enemy.EnemyOnDestroyChange -= OnDestroyChange;
        }
    }
}
