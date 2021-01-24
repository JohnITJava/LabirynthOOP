namespace BallLabirynthOOP
{
    public sealed class PlayerBallModel
    {
        private PlayerBall _playerBall;

        public PlayerBall PlayerBall => _playerBall;

        public PlayerBallModel(PlayerBall playerBall)
        {
            _playerBall = playerBall;
        }

    }
}
