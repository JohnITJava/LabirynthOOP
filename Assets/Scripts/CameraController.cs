using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraController : IUpdateble
    {

        private CameraModel _cameraModel;


        public CameraController(CameraModel cameraModel)
        {
            _cameraModel = cameraModel;
        }


        public void UpdateTick()
        {
            _cameraModel.LateMove();
        }
    }
}
