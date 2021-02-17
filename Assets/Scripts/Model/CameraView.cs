using System;
using UnityEngine;
using Rand = UnityEngine.Random;


namespace BallLabirynthOOP
{

    [Serializable]
    internal sealed class CameraView
    {
        private CameraData _cameraData;
        private Camera _camera;
        private PlayerBall _player;

        private Vector3 _offset;
        private Vector3 _newPosition;

        private bool _isShakeTriggered;


        internal CameraView(Camera camera, CameraData cameraData)
        {
            _camera = camera;
            _player = cameraData.PlayerBallReference;
            _cameraData = cameraData;
        }

        public PlayerBall Player => _player;

        public bool IsShakeTriggered => _isShakeTriggered;


        public void ShakeTrigger(bool on_off)
        {
            _isShakeTriggered = on_off;
        }


        public void Shake()
        {
            if (_cameraData.ShakeDuration > 0)
            {
                var currentPosition = _camera.transform.position;

                float x = Rand.Range(-1f, 1f) * _cameraData.ShakeAmount;
                float y = Rand.Range(-1f, 1f) * _cameraData.ShakeAmount;
                float z = Rand.Range(-1f, 1f) * _cameraData.ShakeAmount;

                _newPosition.Set(currentPosition.x - x, currentPosition.y - y, currentPosition.z - z);
                _camera.transform.position = _newPosition;

                _cameraData.ShakeDuration -= Time.deltaTime;
            }
            else
            {
                ShakeTrigger(false);
                _cameraData.ShakeDuration = _cameraData.DefaultShakeDuration;
            }
        }


        public void Initialize()
        {
            _offset = _camera.transform.position - _player.Ball.transform.position;
        }


        public void LateMove()
        {
            if (!_isShakeTriggered)
            {
                _camera.transform.position = _player.Ball.transform.position + _offset;
            }
        }

    }
}
