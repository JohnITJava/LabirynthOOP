using UnityEngine;
using UnityEngine.UI;


namespace BallLabirynthOOP
{
    public sealed class DisplayInfo : IView
    {
        private Text _text;
        private int _point;

        public DisplayInfo()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(int value)
        {
            _point += value;
            _text.text = $"Вы набрали {_point}";
        }
    }
}
