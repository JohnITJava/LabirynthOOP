namespace BallLabirynthOOP
{
    internal sealed class CameraModel
    {

        private CameraView _cameraView;

        internal CameraModel(CameraView cameraView)
        {
            _cameraView = cameraView;
        }

        public CameraView CameraView => _cameraView;

    }
}
