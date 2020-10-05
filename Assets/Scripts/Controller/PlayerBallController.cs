using System;
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

        private void OnBonusChangeReaction(object player, EventTypeCast<InteractiveObject> args)
        {
            var playerBall = (PlayerBall)player;
            var cube = (BonusCube) args.InteractiveObj;
            var cubePoints = cube.Points;
            var id = cube.BonusCubeObject.GetInstanceID();
            playerBall.AddBonus(cubePoints);
        }


        public void UpdateTick()
        {
            _playerBallModel.PlayerBall.Move();
        }
    }
}
