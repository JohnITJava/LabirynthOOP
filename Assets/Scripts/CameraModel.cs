using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraModel
    {

        private Camera _camera;
        private PlayerBall _player;

        private Vector3 _offset;


        public CameraModel(Camera camera, PlayerBall playerBall)
        {
            _camera = camera;
            _player = playerBall;
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
