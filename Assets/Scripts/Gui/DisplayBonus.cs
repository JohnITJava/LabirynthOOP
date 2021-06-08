using System;


namespace BallLabirynthOOP
{
    internal sealed class DisplayBonus : DisplayInfoBase
    {
        public float StartedMessageDefinition = -101.0001f;
        public string PlayerCaughtMsg = "Player was caught by Type: [{0}] - ID: [{1}] with Color: [{2}]";

        internal DisplayBonus(PlayerBase player)
        {
            var playerBall = (PlayerBall)player;

            DisplayBonusInfo(StartedMessageDefinition, playerBall.StartedHPBonus);
            playerBall.OnDamageCaughtEvent += DisplayEnemyInfo;
        }

        public void DisplayBonusInfo(float inputBonus, float ammountBonus)
        {
            var startMsg = PrepareInfoMessage(inputBonus, ammountBonus);
            base.Display(startMsg);
        }

        private string PrepareInfoMessage(float inputBonus, float ammountBonus)
        {
            var msg = "";
            float playerPoints = ammountBonus;
            if (inputBonus == StartedMessageDefinition)
            {
                msg = $"STARTED. CURRENT {playerPoints}";
            }
            else if (inputBonus >= 0)
            {
                msg = $"GET {inputBonus} points: CURRENT {playerPoints}";
            }
            else if (inputBonus < 0)
            {
                msg = $"LOOSE {inputBonus} points: CURRENT {playerPoints}";
            }
            return msg;
        }

        private void DisplayEnemyInfo(EnemyInfo info)
        {
            var msg = info.ToString(PlayerCaughtMsg);
            base.Display(msg);
        }
    }
}
