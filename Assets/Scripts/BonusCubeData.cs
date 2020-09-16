using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "BonusCubeData", menuName = "Data Objects")]
    public sealed class BonusCubeData : ScriptableObject
    {
        public BonusCube BonusCube;
    }
}
