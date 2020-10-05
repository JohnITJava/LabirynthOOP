namespace BallLabirynthOOP
{
    public sealed class InitializeController
    {
        public InitializeController(MainController mainController, PlayerBallData playerBallData, BonusCubeData bonusCubeData, CameraData cameraData)
        {
            new PlayerBallInitializator(mainController, playerBallData, cameraData);

            new CameraInitializator(mainController, cameraData);

            new BonusCubeInitializator(mainController, bonusCubeData, cameraData);

            new GUIInizializator(mainController);
        }
    }
}
