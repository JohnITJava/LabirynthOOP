using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "PlayerBallData", menuName = "Data/Player Ball", order = 1)]
    internal sealed class PlayerBallData : ScriptableObject, IUnit
    {
        public PlayerBall PlayerBall;

        public float Speed => PlayerBall.Speed;
    }
}
