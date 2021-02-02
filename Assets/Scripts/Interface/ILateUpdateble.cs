namespace BallLabirynthOOP
{
    public interface ILateUpdateble : IController
    {
        void LateExecute(float deltaTime);
    }
}
