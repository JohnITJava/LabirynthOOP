namespace BallLabirynthOOP
{
    public sealed class PlayerBallController : IUpdateble
    {

        private PlayerBallModel _playerBallModel;


        public PlayerBallController(PlayerBallModel playerBallModel)
        {
            _playerBallModel = playerBallModel;
            SignToBonusChangeEvent();
        }


        private void SignToBonusChangeEvent()
        {
            _playerBallModel.PlayerBall.OnBonusPointsChange += OnBonusChangeReaction;
        }


        private void OnBonusChangeReaction(object obj, BonusChangeEventArgs args)
        {
            var player = (PlayerBall)obj;
            var cube = (BonusCube)args.InteractiveObj;
            player.Points += cube.Points;
        }


        public void UpdateTick()
        {
            _playerBallModel.PlayerBall.Move();
        }
    }
}
