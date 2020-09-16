using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class CameraInitializator
    {
        public CameraInitializator(MainController mainController, CameraData cameraData)
        {

            var createdCamera = Object.Instantiate(cameraData.GetBallData.playerBall.MainCamera,
                new Vector3(cameraData.GetBallData.playerBall.StartPosition.x, cameraData.StartedOffset.y, cameraData.StartedOffset.z),
                Quaternion.identity);

            createdCamera.transform.rotation = Quaternion.Euler(new Vector3(75.0f, 180.0f, 0.0f));
            cameraData.GetBallData.playerBall.MainCamera = createdCamera;

            var cameraModel = new CameraModel(cameraData);
            cameraModel.PreIniting();

            mainController.AddLateUpdatable(new CameraController(cameraModel));

        }
    }
}
