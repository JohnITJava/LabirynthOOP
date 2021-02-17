using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "DisplayInfo", menuName = "Data/Display Info")]
    internal sealed class DisplayInfoData : ScriptableObject
    {
        public DisplayBonus DisplayBonus;
        public DisplayEndGame DisplayEndGame;
    }

}
