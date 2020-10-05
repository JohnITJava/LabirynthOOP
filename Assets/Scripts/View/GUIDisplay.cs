using UnityEngine;
using TMPro;
using System;


namespace BallLabirynthOOP
{
    public sealed class GUIDisplay : MonoBehaviour, IView
    {
        [SerializeField] private Rect _areaRect = new Rect(0, 0, 1200, 100);

        [SerializeField] private GUIStyle _guiStyle;
        [SerializeField] private GUISkin _guiSkin;
        [SerializeField] private GUIContent _guiContent;
        [SerializeField] private GUISettings _guiSettings;
        [SerializeField] private TMP_Text _greetingMessage;

        private static GUIDisplay _instance;
        private TextMeshProUGUI _bonusMessagTMPRO;


        private GUIDisplay() { }
        public static GUIDisplay Instance { get => _instance; }
        public Rect AreaRect { get => _areaRect; set => _areaRect = value; }

        private void Awake()
        {
            _instance = GetComponent<GUIDisplay>();

            try
            {
                if (_greetingMessage is null)
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
            //_guiStyle = new GUIStyle();
            _guiStyle.fontSize = 18;
            _guiStyle.fontStyle = FontStyle.Bold;
            _guiStyle.wordWrap = true;


            GUILayout.BeginArea(_areaRect);
            GUI.Box(new Rect(0, 0, 200, 50), _bonusMessagTMPRO.text, _guiStyle);
            GUI.backgroundColor = new Color(0, 0, 0, .5f);
            GUI.color = Color.red;
            GUILayout.EndArea();
        }


        public void Display(string message)
        {
            _bonusMessagTMPRO.text += message;
        }
    }
}
