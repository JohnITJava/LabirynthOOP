using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraData
    {
        private PlayerBall _playerBallReference;
        private Vector3 _startPositionOffset = new Vector3(0.0f, 7.0f, 16.0f);

        public PlayerBall PlayerBallReference
        {
            get => _playerBallReference;
            set
            {
                _playerBallReference = value;
            }
        }

        public Vector3 StartedOffset => _startPositionOffset;
    }
}
