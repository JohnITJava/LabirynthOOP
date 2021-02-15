using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    [Serializable]
    public sealed class EnemyProvider
    {
        [SerializeField]
        private GameObject _enemyPrefab;

        public GameObject EnemyPrefab() => _enemyPrefab;
    }
}
