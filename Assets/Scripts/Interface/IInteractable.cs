namespace BallLabirynthOOP
{
    public interface IInteractable : IAction, IInizialization
    {
        bool IsInteractable { get; }
    }
}
