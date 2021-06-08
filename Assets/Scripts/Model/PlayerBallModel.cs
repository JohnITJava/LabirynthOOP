namespace BallLabirynthOOP
{
    internal sealed class PlayerBallModel
    {
        private PlayerBall _playerBall;

        public PlayerBall PlayerBall => _playerBall;

        internal PlayerBallModel(PlayerBall playerBall)
        {
            _playerBall = playerBall;
        }

    }
}
