using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class BonusCubeInitializator
    {
        public BonusCubeInitializator(MainController mainController, BonusCubeData bonusData, CameraData cameraData)
        {
            BonusCubeController bonusCubeController = new BonusCubeController(bonusData, cameraData);
           
            mainController.AddUpdatable(bonusCubeController);
            mainController.AddFixedUpdatable(bonusCubeController);
            mainController.AddDrawUpdatable(bonusCubeController);
        }

    }
}