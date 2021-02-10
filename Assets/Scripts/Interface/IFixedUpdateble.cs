namespace BallLabirynthOOP
{
    public interface IFixedUpdateble : IController
    {
        void FixedExecute(float deltaTime);
    }
}
