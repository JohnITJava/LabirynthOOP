namespace BallLabirynthOOP
{
    internal sealed class CameraController : IUpdateble, ILateUpdateble
    {

        private const float START_ELAPSE = 0.0f;

        private CameraModel _cameraModel;
        private CameraData _cameraData;


        internal CameraController(CameraModel cameraModel)
        {
            _cameraModel = cameraModel;
            SignToBonusChangeEvent();
        }


        private void SignToBonusChangeEvent()
        {
            _cameraModel.CameraView.Player.OnBonusPointsChangeEvent += OnBonusChangeReaction;
        }


        public void OnBonusChangeReaction(object value, EventTypeCast<InteractiveObject> args)
        {
            if (((BonusCube)args.InteractiveObj).BonusType.Equals(BonusType.BadBonus))
            {
                _cameraModel.CameraView.ShakeTrigger(true);
            }
        }


        public void Execute(float deltaTime)
        {
            if (_cameraModel.CameraView.IsShakeTriggered)
            {
                _cameraModel.CameraView.Shake();
            }
        }

        public void LateExecute(float deltaTime)
        {
            _cameraModel.CameraView.LateMove();
        }
    }
}
