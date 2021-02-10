using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class PlayerBallInitializator : IInizialization
    {
        private PlayerBallModel _playerBallModel;

        public PlayerBallModel PlayerBallModel => _playerBallModel;

        internal PlayerBallInitializator(ControllersExecutor controllersExecutor, IPlayerFactory factory, CameraData cameraData)
        {
            //var spawnedBall = Object.Instantiate(
            //    ballData.PlayerBall.Ball,
            //    ballData.PlayerBall.StartPosition,
            //    Quaternion.identity);

            //var playerBall = new PlayerBall(
            //    spawnedBall,
            //    ballData.PlayerBall.Speed,
            //    ballData.PlayerBall.StartPosition);

            PlayerBall playerBall = (PlayerBall) factory.CreatePlayer();

            cameraData.PlayerBallReference = playerBall;

            _playerBallModel = new PlayerBallModel(playerBall);

            controllersExecutor.Add(new PlayerBallController(_playerBallModel));
        }

        public void Initialization() {}
    }
}
