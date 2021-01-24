using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class PlayerBallInitializator
    {
        public PlayerBallInitializator(MainController mainController, PlayerBallData ballData, CameraData cameraData)
        {
            var spawnedBall = Object.Instantiate(
                ballData.PlayerBall.Ball,
                ballData.PlayerBall.StartPosition,
                Quaternion.identity);

            var playerBall = new PlayerBall(
                spawnedBall,
                ballData.PlayerBall.Speed,
                ballData.PlayerBall.StartPosition);

            cameraData.PlayerBallReference = playerBall;

            var playerBallModel = new PlayerBallModel(playerBall);
            mainController.AddUpdatable(new PlayerBallController(playerBallModel));
        }
    }
}
