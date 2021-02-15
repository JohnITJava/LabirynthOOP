using UnityEngine;
using System.Collections.Generic;
using System.Linq;


namespace BallLabirynthOOP
{
    internal sealed class BonusCubeController : IUpdateble, IFixedUpdateble, IDrawUpdateble
    {
        private List<BonusCubeModel> _bonusModels = new List<BonusCubeModel>();
        private DisplayBonus _displayBonuses;
        private CameraData _cameraData;


        public List<BonusCubeModel> BonusCubeModels => _bonusModels;


        internal BonusCubeController(BonusCubeData cubeData, CameraData cameraData)
        {
            _cameraData = cameraData;

            GameObject bonusCubeObj = null;
            for (int i = 0; i < Positions.BonusPositions.Count; i++)
            {
                bonusCubeObj = Object.Instantiate(cubeData.BonusCube.BonusCubeObject, Positions.BonusPositions[i], Quaternion.identity);
                BonusCube bonusCube = new BonusCube(bonusCubeObj);

                var bonusCubeModel = new BonusCubeModel(bonusCube);

                bonusCube.OnDestroyChange += InteractiveObjectOnDestroyChange;

                _bonusModels.Add(bonusCubeModel);
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < _bonusModels.Count; i++)
            {
                _bonusModels[i].BonusCube.Interaction();
            }

        }

        public void FixedExecute(float deltaTime)
        {
            for (int i = 0; i < _bonusModels.Count; i++)
            {
                _bonusModels[i].BonusCube.OnTrigger();
            }
        }

        public void DrawExecute(float deltaTime)
        {
            for (int i = 0; i < _bonusModels.Count; i++)
            {
                _bonusModels[i].BonusCube.DrawGizmo();
            }
        }

        private void InteractiveObjectOnDestroyChange(InteractiveObject obj)
        {
            var cube = (BonusCube)obj;
            _cameraData.CameraView.Player.EventSignersInvoke(cube);
            obj.OnDestroyChange -= InteractiveObjectOnDestroyChange;
            var relativeModel = _bonusModels.First(e => e.BonusCube.Equals(cube));
            if (relativeModel != null)
            {
                _bonusModels.Remove(relativeModel);
            }
        }
    }
}
