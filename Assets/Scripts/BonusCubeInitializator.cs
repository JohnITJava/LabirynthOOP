using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class BonusCubeInitializator
    {
        public BonusCubeInitializator(MainController mainController, BonusCubeData bonusData)
        {
            List<BonusCubeModel> bonusModels = new List<BonusCubeModel>();
            GameObject bonusCubeTemp = null;

            for (int i = 0; i < Constants.BonusPositions.Count; i++)
            {
                
                bonusCubeTemp = Object.Instantiate(bonusData.BonusCube.BonusCubeObject, Constants.BonusPositions[i], Quaternion.identity);
                var bonusCube = new BonusCube(bonusCubeTemp);
                var bonusCubeModel = new BonusCubeModel(bonusCube);
                bonusModels.Add(bonusCubeModel);
            }

            mainController.AddUpdatable(new BonusCubeController(bonusModels));
            mainController.AddFixedUpdatable(new BonusCubeController(bonusModels));
        }
    }
}
