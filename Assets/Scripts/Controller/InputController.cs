using System;


namespace BallLabirynthOOP
{
    internal sealed class InputController : IUpdateble, IController
    {
        private readonly IUserInputProxy _horizontal;
        private readonly IUserInputProxy _vertical;

        internal InputController((IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }
    }
}
