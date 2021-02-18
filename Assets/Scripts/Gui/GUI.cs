using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace BallLabirynthOOP
{
    internal class GUI
    {
        private GameObject _guiCanvas;
        private GameObject _infoPanel;
        private GameObject _buttonPanel;

        private TextMeshProUGUI _info_text;
        private Button _restartGameButton;

        internal GUI(GameObject canvas, GameObject infoPanel, GameObject buttonPanel)
        {
            InitGuiElements(canvas, infoPanel, buttonPanel);
        }

        private void InitGuiElements(GameObject canvas, GameObject infoPanel, GameObject buttonPanel)
        {
            _guiCanvas = UnityEngine.Object.Instantiate(canvas);
            _infoPanel = UnityEngine.Object.Instantiate(infoPanel, _guiCanvas.transform);
            _info_text = _infoPanel.GetComponentInChildren<TextMeshProUGUI>();
            _buttonPanel = UnityEngine.Object.Instantiate(buttonPanel, _guiCanvas.transform);
            _restartGameButton = _buttonPanel.GetComponentInChildren<Button>();
        }
    }
}
