using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class BonusCubeInitializator
    {
        public BonusCubeInitializator(MainController mainController, BonusCubeData bonusData)
        {            
            GameObject bonusCubeTemp = null;
            BonusCubeController bonusCubeController = null;

            for (int i = 0; i < Constants.BonusPositions.Count; i++)
            {
                
                bonusCubeTemp = Object.Instantiate(bonusData.BonusCube.BonusCubeObject, Constants.BonusPositions[i], Quaternion.identity);
                BonusCube bonusCube = new BonusCube(bonusCubeTemp);

                var bonusCubeModel = new BonusCubeModel(bonusCube);
                bonusCubeController = new BonusCubeController(mainController, bonusCubeModel);
                mainController.AddUpdatable(bonusCubeController);
                mainController.AddFixedUpdatable(bonusCubeController);
                mainController.AddDrawUpdatable(bonusCubeController);
            }                
        }
    }
}
