using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerBallData _playerData;

        internal PlayerFactory(PlayerBallData playerData)
        {
            _playerData = playerData;
        }

        public object CreatePlayer()
        {
            var spawnedBall = UnityEngine.Object.Instantiate(
               _playerData.PlayerBall.Ball,
               _playerData.PlayerBall.StartPosition,
               Quaternion.identity)
                .SetName("Player");


            var playerBall = new PlayerBall(
                spawnedBall,
                _playerData.PlayerBall.Speed,
                _playerData.PlayerBall.StartPosition);

            return playerBall;
        }
    }
}
