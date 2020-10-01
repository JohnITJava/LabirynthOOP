namespace BallLabirynthOOP
{
    public sealed class GUIInizializator
    {
        private MainController _mainController;

        public GUIInizializator(MainController mainController)
        {
            mainController.AddGuiUpdatable(new GUIController());
        }
    }
}