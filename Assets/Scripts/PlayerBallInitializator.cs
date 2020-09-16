using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class PlayerBallInitializator
    {
        public PlayerBallInitializator(MainController mainController, PlayerBallData ballData)
        {
            var spawnedBall = Object.Instantiate(ballData.playerBall.Ball,
                ballData.playerBall.StartPosition,
                 Quaternion.identity);

            var playerBall = ballData.playerBall;
            playerBall.Ball = spawnedBall;

            var playerBallModel = new PlayerBallModel(playerBall);
            mainController.AddUpdatable(new PlayerBallController(playerBallModel));
        }
    }
}
