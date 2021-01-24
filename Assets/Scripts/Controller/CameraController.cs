namespace BallLabirynthOOP
{
    public sealed class CameraController : IUpdateble, ILateUpdateble
    {

        private const float START_ELAPSE = 0.0f;

        private CameraModel _cameraModel;
        private CameraData _cameraData;


        public CameraController(CameraModel cameraModel)
        {
            _cameraModel = cameraModel;
            SignToBonusChangeEvent();
        }


        private void SignToBonusChangeEvent()
        {
            _cameraModel.CameraView.PlayerBall.OnBonusPointsChangeEvent += OnBonusChangeReaction;
        }


        public void OnBonusChangeReaction(object value, EventTypeCast<InteractiveObject> args)
        {
            if (((BonusCube)args.InteractiveObj).BonusType.Equals(BonusType.BadBonus))
            {
                _cameraModel.CameraView.ShakeTrigger(true);
            }
        }


        void IUpdateble.UpdateTick()
        {
            if (_cameraModel.CameraView.IsShakeTriggered)
            {
                _cameraModel.CameraView.Shake();
            }
        }

        void ILateUpdateble.UpdateTick()
        {
            _cameraModel.CameraView.LateMove();
        }
    }
}
