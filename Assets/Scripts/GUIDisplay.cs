using UnityEngine;
using TMPro;
using System;


namespace BallLabirynthOOP
{
    public delegate void DisplayDelegate(string message);

    [Serializable]
    public sealed class GUIDisplay : MonoBehaviour, IView
    {
        public GUIStyle _guiStyle;
        public GUISkin _guiSkin;
        public GUIContent _guiContent;
        public GUISettings _guiSettings;
        public TextMeshProUGUI _textMesh;

        private void Start()
        {
        }

        private void OnGUI()
        {
            RenderBonusPanel();
        }

        private void RenderBonusPanel()
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 24;
            style.fontStyle = FontStyle.Bold;

            GUILayout.BeginArea(new Rect(0, 0, 400, 50));
            GUI.Box(new Rect(0, 0, 200, 50), _textMesh.text, style);
            GUI.backgroundColor = new Color(0, 0, 0, .5f);
            GUI.color = Color.red;
            GUILayout.EndArea();
        }

        public void Display(string message)
        {
            _textMesh.text = message;
        }
    }
}
