
namespace BallLabirynthOOP
{
    public sealed class PlayerBallController : IUpdateble
    {
        private PlayerBallModel _playerBallModel;

        public PlayerBallController(PlayerBallModel playerBallModel)
        {
            _playerBallModel = playerBallModel;
        }

        public void UpdateTick()
        {
            _playerBallModel.PlayerBall.Move();
        }
    }
}
