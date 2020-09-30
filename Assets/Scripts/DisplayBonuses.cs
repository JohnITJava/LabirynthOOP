using UnityEngine;
using TMPro;


namespace BallLabirynthOOP
{
    public sealed class DisplayBonuses : IView
    {
        private TextMeshProUGUI _textMesh;
        private int _point;

        public DisplayBonuses(TextMeshProUGUI textMesh)
        {
            _textMesh = textMesh;
        }

        public void RenderBonusPanel() => GUI.Box(new Rect(0, 0, 200, 50), new GUIContent(_textMesh.text));

        public void Display(int value)
        {
            _point += value;
            _textMesh.text = $"You get points: current {_point}";
        }
    }
}
