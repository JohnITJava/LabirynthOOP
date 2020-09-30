using UnityEngine;
using System.Collections.Generic;
using System.Linq;


namespace BallLabirynthOOP
{
    public sealed class BonusCubeController : IUpdateble, FixedUpdateble, IDrawUpdateble, IGuiUpdateble
    {
        private List<BonusCubeModel> _bonusModels = new List<BonusCubeModel>();
        private DisplayBonuses _displayBonuses;

        public List<BonusCubeModel> BonusCubeModels => _bonusModels;

        public BonusCubeController(BonusCubeData cubeData, DisplayBonuses displayBonuses)
        {
            _displayBonuses = displayBonuses;

            GameObject bonusCubeObj = null;
            for (int i = 0; i < Constants.BonusPositions.Count; i++)
            {
                bonusCubeObj = Object.Instantiate(cubeData.BonusCube.BonusCubeObject, Constants.BonusPositions[i], Quaternion.identity);
                BonusCube bonusCube = new BonusCube(bonusCubeObj);

                bonusCube.Initialization(displayBonuses);
                var bonusCubeModel = new BonusCubeModel(bonusCube);

                bonusCube.OnDestroyChange += InteractiveObjectOnDestroyChange;

                _bonusModels.Add(bonusCubeModel);
            }
        }

        void IUpdateble.UpdateTick()
        {
            for (int i = 0; i < _bonusModels.Count; i++)
            {
                _bonusModels[i].BonusCube.Interaction();
            }

        }

        void FixedUpdateble.UpdateTick()
        {
            for (int i = 0; i < _bonusModels.Count; i++)
            {
                _bonusModels[i].BonusCube.OnTrigger();
            }
        }

        void IDrawUpdateble.UpdateTick()
        {
            for (int i = 0; i < _bonusModels.Count; i++)
            {
                _bonusModels[i].BonusCube.DrawGizmo();
            }
        }

        void IGuiUpdateble.UpdateTick()
        {
            _displayBonuses.RenderBonusPanel();
        }

        private void InteractiveObjectOnDestroyChange(InteractiveObject value)
        {
            value.OnDestroyChange -= InteractiveObjectOnDestroyChange;
            var relativeModel = _bonusModels.First(e => e.BonusCube.Equals((BonusCube)value));
            if (relativeModel != null)
            {
                _bonusModels.Remove(relativeModel);
            }
        }
    }
}
