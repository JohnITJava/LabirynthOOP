namespace BallLabirynthOOP
{
    internal sealed class GUIInizializator : IInizialization
    {
        private MainController _mainController;

        internal GUIInizializator(ControllersExecutor controllersExecutor)
        {
            controllersExecutor.Add(new GUIController());
        }

        public void Initialization() {}
    }
}