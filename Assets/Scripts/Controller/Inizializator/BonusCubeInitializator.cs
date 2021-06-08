using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    internal sealed class BonusCubeInitializator : IInizialization
    {
        internal BonusCubeInitializator(ControllersExecutor controllersExecutor, BonusCubeData bonusData, CameraData cameraData)
        {
            BonusCubeController bonusCubeController = new BonusCubeController(bonusData, cameraData);

            controllersExecutor.Add(bonusCubeController);
        }

        public void Initialization() {}
    }
}