using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraModel
    {

        private Camera _camera;
        private PlayerBall _player;

        private Vector3 _offset;


        public CameraModel(CameraData cameraData)
        {
            _camera = cameraData.GetBallData.playerBall.MainCamera;
            _player = cameraData.GetBallData.playerBall;
        }

        public void PreIniting()
        {
            _offset = _camera.transform.position - _player.Ball.transform.position;
        }

        public void LateMove()
        {
            _camera.transform.position = _player.Ball.transform.position + _offset;
        }
    }
}
