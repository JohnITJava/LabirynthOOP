using UnityEngine;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "CameraData", menuName = "Data/Camera Data", order = 3)]
    internal sealed class CameraData : ScriptableObject
    {
        public Camera MainCamera;

        public Vector3 StartPositionOffset = new Vector3(0.0f, 7.0f, 16.0f);
        public Vector3 DefaultRotation = new Vector3(75.0f, 180.0f, 0.0f);

        public float ShakeDuration = 1.0f;
        public float ShakeAmount = 0.1f;
        public float DecreaseFactor = 1.0f;

        private PlayerBall _playerBallReference;
        private CameraView _cameraView;

        private float _defaultShakeDuration;


        public PlayerBall PlayerBallReference
        {
            get => _playerBallReference;
            set
            {
                _playerBallReference = value;
            }
        }


        public float DefaultShakeDuration
        {
            get => _defaultShakeDuration;
            set => _defaultShakeDuration = value;
        }


        public CameraView CameraView
        {
            get => _cameraView;
            set => _cameraView = value;
        }

    }
}
