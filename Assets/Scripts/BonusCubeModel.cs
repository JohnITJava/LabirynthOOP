namespace BallLabirynthOOP
{
    public sealed class BonusCubeModel
    {
        private BonusCube _bonusCube;
        private System.Type _defaultBehaviour;

        public BonusCube BonusCube => _bonusCube;

        public BonusCubeModel(BonusCube bonusCube)
        {
            _bonusCube = bonusCube;
            _defaultBehaviour = bonusCube.ChooseRandDefaultBehaviour();
        }

    }
}
