using System;

namespace BallLabirynthOOP
{
    public sealed class BonusCubeModel : IEnemy
    {
        private BonusCube _bonusCube;

        public event Action<IEnemy> EnemyOnDestroyChange;

        public BonusCube BonusCube => _bonusCube;

        public BonusCubeModel(BonusCube bonusCube)
        {
            _bonusCube = bonusCube;
        }

        public void Move()
        {
            _bonusCube.Move();
        }

        public void OnTrigger()
        {
            _bonusCube.OnTrigger();
        }
    }
}
