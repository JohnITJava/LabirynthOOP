namespace BallLabirynthOOP
{
    public sealed class InitializeController
    {
        public InitializeController(MainController mainController, PlayerBallData playerBallData, BonusCubeData bonusCubeData)
        {
            new PlayerBallInitializator(mainController, playerBallData);

            new CameraInitializator(mainController, playerBallData);

            new BonusCubeInitializator(mainController, bonusCubeData);
        }
    }
}
