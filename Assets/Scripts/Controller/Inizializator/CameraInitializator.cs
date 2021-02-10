using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class CameraInitializator : IInizialization
    {
        internal CameraInitializator(ControllersExecutor controllersExecutor, CameraData cameraData)
        {

            var createdCamera = Object.Instantiate(cameraData.MainCamera,
                new Vector3(cameraData.StartPositionOffset.x, cameraData.StartPositionOffset.y, cameraData.StartPositionOffset.z),
                Quaternion.identity);

            createdCamera.transform.rotation = Quaternion.Euler(cameraData.DefaultRotation);

            CameraView cameraView = new CameraView(createdCamera, cameraData);
            cameraView.Initialize();


            cameraData.CameraView = cameraView;
            cameraData.DefaultShakeDuration = cameraData.ShakeDuration;
            var cameraModel = new CameraModel(cameraView);

            var cameraController = new CameraController(cameraModel);

            controllersExecutor.Add(cameraController);
            controllersExecutor.Add(cameraController);
        }

        public void Initialization() {}
    }
}
