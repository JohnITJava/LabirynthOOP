using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraModel
    {

        private CameraView _cameraView;

        public CameraModel(CameraView cameraView)
        {
            _cameraView = cameraView;
        }

        public CameraView CameraView => _cameraView;

    }
}
