namespace BallLabirynthOOP
{
    internal sealed class InputInitializator : IInizialization
    {
        private IUserInputProxy _pcInputHorizontal;
        private IUserInputProxy _pcInputVertical;

        internal InputInitializator(ControllersExecutor controllersExecutor)
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVertical = new PCInputVertical();

            var inputController = new InputController((_pcInputHorizontal, _pcInputVertical));
            controllersExecutor.Add(inputController);
        }

        public void Initialization() { }

        public (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) result = (_pcInputHorizontal, _pcInputVertical);
            return result;
        }

    }
}
