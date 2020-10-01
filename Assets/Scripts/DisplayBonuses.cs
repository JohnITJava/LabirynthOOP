using TMPro;
using UnityEngine;

namespace BallLabirynthOOP
{

    public sealed class DisplayBonuses
    {
        private string _text;
        private static int _points;
        private DisplayDelegate _displayDelegate;

        private GUIDisplay _guiDisplay;

        public DisplayBonuses()
        {
            _guiDisplay = GameObject.FindObjectOfType<GUIDisplay>();
        }

        public void Display()
        {
            _guiDisplay.Display(_text);
        }

        public void PrepareInfoMessage(int value)
        {
            _points += value;
            if (value > 0)
            {
                _text = $"You get {value} points: current {_points}";
            }
            else if (value < 0)
            {
                _text = $"You loose {value} points: current {_points}";
            }
        }
    }
}
