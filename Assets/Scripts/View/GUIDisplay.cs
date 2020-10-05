using UnityEngine;
using TMPro;
using System;


namespace BallLabirynthOOP
{

    [Serializable]
    public sealed class GUIDisplay : MonoBehaviour, IView
    {
        private static GUIDisplay _instance;

        public GUIStyle GuiStyle;
        public GUISkin GuiSkin;
        public GUIContent GuiContent;
        public GUISettings GuiSettings;
        public TMP_Text GreetingMessage;

        private TextMeshProUGUI _bonusMessagTMPRO;


        private GUIDisplay() { }
        public static GUIDisplay Instance { get => _instance; }


        private void Awake()
        {
            _instance = GetComponent<GUIDisplay>();

            try
            {
                if (GreetingMessage is null)
                    throw new GUIDisplayException("Forget input TEXTMESHPROUGUI element! Script on MainInitializer! Current: ", null);
                Debug.Log("Forget input TEXTMESHPROUGUI element!");
            }
            catch
            {
                Debug.Log("Try create it for u");
                if (_bonusMessagTMPRO is null)
                    _bonusMessagTMPRO = gameObject.AddComponent<TextMeshProUGUI>();
                _bonusMessagTMPRO.text = "Game Starts! Good Luck!";
            }
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
            GUI.Box(new Rect(0, 0, 200, 50), _bonusMessagTMPRO.text, style);
            GUI.backgroundColor = new Color(0, 0, 0, .5f);
            GUI.color = Color.red;
            GUILayout.EndArea();
        }


        public void Display(string message)
        {
            _bonusMessagTMPRO.text = message;
        }
    }
}
