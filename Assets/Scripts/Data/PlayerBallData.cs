using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "PlayerBallData", menuName = "Data/Player Ball", order = 1)]
    public sealed class PlayerBallData : ScriptableObject
    {
        public PlayerBall PlayerBall;
    }
}
