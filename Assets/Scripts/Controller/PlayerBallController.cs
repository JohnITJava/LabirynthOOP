using UnityEngine;

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
            _playerBallModel.PlayerBall.OnBonusPointsChangeEvent += OnBonusChangeReaction;
        }


        private void OnBonusChangeReaction(object obj, BonusChangeEventArgs args)
        {
            var player = (PlayerBall)obj;
            var cube = (BonusCube)args.InteractiveObj;
            var cubePoints = cube.Points;
            var id = cube.BonusCubeObject.GetInstanceID();
            Debug.Log($"Bonus cube {id} send points: {cubePoints}");

            var playerPoints = player.Points;
            Debug.Log("Current Player Points: " + playerPoints);
            player.AddBonus(cubePoints);
        }


        public void UpdateTick()
        {
            _playerBallModel.PlayerBall.Move();
        }
    }
}
