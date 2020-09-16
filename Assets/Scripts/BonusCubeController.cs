using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class BonusCubeController : IUpdateble, FixedUpdateble
    {
        private List<BonusCubeModel> _bonusModels;

        public BonusCubeController(List<BonusCubeModel> bonusModels)
        {
            _bonusModels = bonusModels;
        }

        void IUpdateble.UpdateTick()
        {
            foreach (var model in _bonusModels)
            {
                model.BonusCube.Interaction();
            }
        }

        void FixedUpdateble.UpdateTick()
        {
            foreach (var model in _bonusModels)
            {
                model.BonusCube.OnTrigger();
            }
        }
    }
}
