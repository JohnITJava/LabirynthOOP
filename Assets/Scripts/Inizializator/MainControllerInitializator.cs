namespace BallLabirynthOOP
{
    internal sealed class MainControllerInitializator
    {
        internal MainControllerInitializator(ControllersExecutor controllersExecutor, Data data)
        {
            controllersExecutor.Initialization();

            new PlayerBallInitializator(controllersExecutor, data.PlayerData, data.CameraData);

            new CameraInitializator(controllersExecutor, data.CameraData);

            new BonusCubeInitializator(controllersExecutor, data.BonusCubeData, data.CameraData);

            new GUIInizializator(controllersExecutor);
        }
    }
}
