using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    internal sealed class BonusCubeInitializator
    {
        internal BonusCubeInitializator(ControllersExecutor controllersExecutor, BonusCubeData bonusData, CameraData cameraData)
        {
            BonusCubeController bonusCubeController = new BonusCubeController(bonusData, cameraData);

            controllersExecutor.Add(bonusCubeController);
            controllersExecutor.Add(bonusCubeController);
            controllersExecutor.Add(bonusCubeController);
        }

    }
}