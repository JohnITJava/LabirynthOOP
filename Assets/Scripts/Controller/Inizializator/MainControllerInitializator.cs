namespace BallLabirynthOOP
{
    internal sealed class MainControllerInitializator
    {
        internal MainControllerInitializator(ControllersExecutor controllersExecutor, Data data)
        {

            var playerFactory = new PlayerFactory(data.PlayerData);
            var playerBallInit = new PlayerBallInitializator(controllersExecutor, playerFactory, data.CameraData);

            var enemyFactory = new EnemyFactory(data.EnemyData);
            var enemyInit = new EnemyInitializator(controllersExecutor, enemyFactory, data.CameraData);

            new CameraInitializator(controllersExecutor, data.CameraData);

            //new BonusCubeInitializator(controllersExecutor, data.BonusCubeData, data.CameraData);

            new GUIInizializator(controllersExecutor);

            var inputInit = new InputInitializator(controllersExecutor);

            new MoveInitializator(controllersExecutor, inputInit.GetInput(), data.PlayerData, playerBallInit.PlayerBallModel.PlayerBall);
        }
    }
}
