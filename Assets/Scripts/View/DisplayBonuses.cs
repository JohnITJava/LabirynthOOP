using UnityEngine;


namespace BallLabirynthOOP
{

    public sealed class DisplayBonuses
    {
        private const float STARTED_POINT_NULL_DEFINITION = -101.0001f;
        private GUIDisplay _guiDisplay;


        public DisplayBonuses(float playerPoints)
        {
            _guiDisplay = GUIDisplay.Instance;
            DisplayBonusInfo(STARTED_POINT_NULL_DEFINITION, playerPoints);
        }

        public void DisplayBonusInfo(float inputBonus, float ammountBonus)
        {
            var startMsg = PrepareInfoMessage(inputBonus, ammountBonus);
            _guiDisplay.Display(startMsg);
        }

        private string PrepareInfoMessage(float inputBonus, float ammountBonus)
        {
            var msg = "";
            float playerPoints = ammountBonus;
            Debug.Log($"In PREPARE method points in: [{inputBonus}] SUMM: [{playerPoints}]");

            if (inputBonus == STARTED_POINT_NULL_DEFINITION)
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
    }
}
