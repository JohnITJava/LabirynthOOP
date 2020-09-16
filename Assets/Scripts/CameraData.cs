using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraData
    {
        private PlayerBallData _playerBallData;
        private Vector3 _startPositionOffset = new Vector3(0.0f, 7.0f, 16.0f);


        public PlayerBallData GetBallData => _playerBallData;
        public Vector3 StartedOffset => _startPositionOffset;


        public CameraData(PlayerBallData playerBallData)
        {
            _playerBallData = playerBallData;
        }
    }
}
