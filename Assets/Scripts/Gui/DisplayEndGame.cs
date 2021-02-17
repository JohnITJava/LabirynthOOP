using System;


namespace BallLabirynthOOP
{

    [Serializable]
    internal sealed class DisplayEndGame : DisplayInfoBase
    {
        public string FinishGameLabel = "Game over! You loose. You was killed by [{0}] of [{1}] color \n" +
                                        "50$ and u can try again! I believe U CAN WIN!";

        internal DisplayEndGame(EnemyInfo info)
        {
            //var playerBall = (PlayerBall) player;
            //playerBall.OnBonusPointsChangeEvent += GameOverEventReaction;
        }


        private void GameOverEventReaction(EnemyInfo info)
        {
            var msg = info.ToString(FinishGameLabel);
        }
    }
}
