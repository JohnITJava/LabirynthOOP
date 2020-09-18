namespace BallLabirynthOOP
{
    public sealed class BonusCubeController : IUpdateble, FixedUpdateble, IDrawUpdateble
    {
        private BonusCubeModel _bonusModel;
        private MainController _mainController;

        public BonusCubeModel BonusCubeModel => _bonusModel;

        public BonusCubeController(MainController mainController, BonusCubeModel bonusModel)
        {
            _bonusModel = bonusModel;
            _bonusModel.BonusCube.OnDestroyChange += InteractiveObjectOnDestroyChange;
        }

        void IUpdateble.UpdateTick()
        {
            _bonusModel.BonusCube.Interaction();
        }

        void FixedUpdateble.UpdateTick()
        {
            _bonusModel.BonusCube.OnTrigger();
        }

        void IDrawUpdateble.UpdateTick()
        {
            _bonusModel.BonusCube.DrawGizmo();
        }

        private void InteractiveObjectOnDestroyChange(InteractiveObject value)
        {
            value.OnDestroyChange -= InteractiveObjectOnDestroyChange;
            _mainController.DeleteDestroyed(this);
        }
    }
}
