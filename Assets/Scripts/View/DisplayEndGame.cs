using System;
using UnityEngine;
using UnityEngine.UI;


namespace BallLabirynthOOP
{

    public sealed class DisplayEndGame
    {

        private Text _finishGameLabel;


        public DisplayEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = String.Empty;
        }


        public void GameOver(object o, Color color)
        {
            _finishGameLabel.text = $"Game over! You loose. You was killed by {((GameObject)o).name} of {color} color \n" +
                                    $"50$ and u can try again! I believe U CAN WIN!";
        }
    }
}
