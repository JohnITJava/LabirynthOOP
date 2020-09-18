namespace BallLabirynthOOP
{
    public sealed class BonusCubeModel
    {
        private BonusCube _bonusCube;

        public BonusCube BonusCube => _bonusCube;

        public BonusCubeModel(BonusCube bonusCube)
        {
            _bonusCube = bonusCube;
            _bonusCube.ChooseRandDefaultBehaviour();
        }

    }
}
