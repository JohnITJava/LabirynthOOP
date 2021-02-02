using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class PlayerBallController : IUpdateble
    {

        private PlayerBallModel _playerBallModel;


        internal PlayerBallController(PlayerBallModel playerBallModel)
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


        public void Execute(float deltaTime)
        {
            _playerBallModel.PlayerBall.Move();
        }
    }
}
