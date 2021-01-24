using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraInitializator
    {
        public CameraInitializator(MainController mainController, CameraData cameraData)
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

            mainController.AddUpdatable(cameraController);
            mainController.AddLateUpdatable(cameraController);
        }
    }
}
