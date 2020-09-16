using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "PlayerBallData", menuName = "Data Objects")]
    public sealed class PlayerBallData : ScriptableObject
    {
        public PlayerBall playerBall;
    }
}
