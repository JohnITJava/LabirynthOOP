using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "PlayerBallData", menuName = "Player Ball", order = 1)]
    public sealed class PlayerBallData : ScriptableObject
    {
        public PlayerBall PlayerBall;
    }
}
