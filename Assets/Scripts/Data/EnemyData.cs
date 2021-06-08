using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "EnemySettings", menuName = "Data/Enemy Data")]
    internal sealed class EnemyData : ScriptableObject
    {
        [Serializable]
        public struct EnemyInfo
        {
            public EnemyType Type;
            public EnemyProvider EnemyPrefabProvider;
        }

        [SerializeField]
        private List<EnemyInfo> _enemyInfos;

        public EnemyProvider GetEnemy(EnemyType type)
        {
            var enemyInfo = _enemyInfos.First(info => info.Type == type);
            return enemyInfo.EnemyPrefabProvider;
        }
    }
}
