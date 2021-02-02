using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class PlayerBallInitializator
    {
        internal PlayerBallInitializator(ControllersExecutor controllersExecutor, PlayerBallData ballData, CameraData cameraData)
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
            controllersExecutor.Add(new PlayerBallController(playerBallModel));
        }
    }
}
