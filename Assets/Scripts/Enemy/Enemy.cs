using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    [Serializable]
    public sealed class Enemy
    {
        public EnemyType type;
        public EnemyProvider EnemyPrefab;
    }
}
