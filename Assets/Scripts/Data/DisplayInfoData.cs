using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "GUIDisplayData", menuName = "Data/GUI Display")]
    internal sealed class DisplayInfoData : ScriptableObject
    {
        public GameObject Canvas;
        public GameObject InfoPanel;
        public GameObject ButtonPanel;
    }

}
