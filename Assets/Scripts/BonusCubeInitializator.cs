using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class BonusCubeInitializator
    {
        public BonusCubeInitializator(MainController mainController, BonusCubeData bonusData)
        {
            DisplayBonuses displayBonuses = new DisplayBonuses(bonusData.tmpro);
            BonusCubeController bonusCubeController = new BonusCubeController(bonusData, displayBonuses);
           
            mainController.AddUpdatable(bonusCubeController);
            mainController.AddFixedUpdatable(bonusCubeController);
            mainController.AddDrawUpdatable(bonusCubeController);
            mainController.AddGuiUpdatable(bonusCubeController);
        }

    }
}