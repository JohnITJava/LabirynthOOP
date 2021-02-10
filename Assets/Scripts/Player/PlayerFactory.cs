using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class PlayerFactory : IPlayerFactory
    {
        private readonly PlayerBallData _playerData;

        public PlayerFactory(PlayerBallData playerData)
        {
            _playerData = playerData;
        }

        public object CreatePlayer()
        {
            var spawnedBall = UnityEngine.Object.Instantiate(
               _playerData.PlayerBall.Ball,
               _playerData.PlayerBall.StartPosition,
               Quaternion.identity);


            var playerBall = new PlayerBall(
                spawnedBall,
                _playerData.PlayerBall.Speed,
                _playerData.PlayerBall.StartPosition);

            return playerBall;
        }
    }
}
