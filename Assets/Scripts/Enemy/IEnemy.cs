using System;


namespace BallLabirynthOOP
{
    public interface IEnemy : IEnemyMove
    {
        event Action<IEnemy> EnemyOnDestroyChange;
    }
}
