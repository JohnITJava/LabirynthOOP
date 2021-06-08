namespace BallLabirynthOOP
{
    public abstract class DisplayInfoBase : IView
    {
        protected GUIDisplay _guiDisplay = GUIDisplay.Instance;

        public void Display(string infoMsg)
        {
            _guiDisplay.Display(infoMsg);
        }
    }
}
