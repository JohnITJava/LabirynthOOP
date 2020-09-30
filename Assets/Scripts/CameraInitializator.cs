using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraInitializator
    {
        public CameraInitializator(MainController mainController, PlayerBallData playerBallData)
        {
            var cameraData = mainController.CameraData;

            var createdCamera = Object.Instantiate(playerBallData.PlayerBall.MainCamera,
                new Vector3(cameraData.StartedOffset.x, cameraData.StartedOffset.y, cameraData.StartedOffset.z),
                Quaternion.identity);

            createdCamera.transform.rotation = Quaternion.Euler(new Vector3(75.0f, 180.0f, 0.0f));
            //cameraData.GetBallData.PlayerBall.MainCamera = createdCamera;
            var cameraModel = new CameraModel(createdCamera, cameraData.PlayerBallReference);

            cameraModel.PreIniting();
            mainController.AddLateUpdatable(new CameraController(cameraModel));

        }
    }
}
