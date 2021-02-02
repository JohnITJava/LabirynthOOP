namespace BallLabirynthOOP
{
    internal sealed class GUIInizializator
    {
        private MainController _mainController;

        internal GUIInizializator(ControllersExecutor controllersExecutor)
        {
            controllersExecutor.Add(new GUIController());
        }
    }
}