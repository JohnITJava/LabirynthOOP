namespace BallLabirynthOOP
{
    internal sealed class GUIInizializator : IInizialization
    {
        private GUI _gui;

        internal GUIInizializator(ControllersExecutor controllersExecutor, DisplayInfoData data)
        {
            _gui = new GUI(data.Canvas, data.InfoPanel, data.ButtonPanel);

            controllersExecutor.Add(new GUIController());
            controllersExecutor.Add(this);
        }

        public void Initialization() {}
    }
}