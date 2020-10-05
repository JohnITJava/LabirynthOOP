using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "DisplayInfo", menuName = "Data/Display Info")]
    public sealed class DisplayInfoData : ScriptableObject
    {
        public DisplayBonus DisplayBonus;
        public DisplayEndGame DisplayEndGame;
    }

}
