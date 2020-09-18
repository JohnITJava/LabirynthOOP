using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class PlayerBallInitializator
    {
        public PlayerBallInitializator(MainController mainController, PlayerBallData ballData)
        {
            var spawnedBall = Object.Instantiate(ballData.PlayerBall.Ball,
                (Vector3)ballData.PlayerBall.StartPosition,
                 Quaternion.identity);

            var playerBall = new PlayerBall(spawnedBall, ballData.PlayerBall.Speed, ballData.PlayerBall.StartPosition);
            mainController.CameraData.PlayerBallReference = playerBall;

            var playerBallModel = new PlayerBallModel(playerBall);
            mainController.AddUpdatable(new PlayerBallController(playerBallModel));
        }
    }
}
