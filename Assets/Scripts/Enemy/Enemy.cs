using System;


namespace BallLabirynthOOP
{
    [Serializable]
    internal sealed class Enemy
    {
        public EnemyType type;
        public EnemyProvider EnemyPrefab;
    }
}
