using UnityEngine;


namespace BallLabirynthOOP
{
    public sealed class MainController : MonoBehaviour
    {
        [SerializeField] private Data _data;

        private ControllersExecutor _controllersExecutor;

        private float _updateDeltaTime;
        private float _lateDeltaTime;
        private float _fixedDeltaTime;
        private float _drawDeltaTime;
        private float _guiDeltaTime;


        private void Start()
        {
            _controllersExecutor = new ControllersExecutor();
            new MainControllerInitializator(_controllersExecutor, _data);
        }

        private void Update()
        {
            _updateDeltaTime = Time.deltaTime;
            _controllersExecutor.Execute(_updateDeltaTime);
        }

        private void LateUpdate()
        {
            _lateDeltaTime = Time.deltaTime;
            _controllersExecutor.LateExecute(_lateDeltaTime);
        }

        private void FixedUpdate()
        {
            _fixedDeltaTime = Time.deltaTime;
            _controllersExecutor.FixedExecute(_fixedDeltaTime);
        }

        //private void OnDrawGizmos()
        //{
        //_drawDeltaTime = Time.deltaTime;
        //_controllersExecutor.DrawExecute(_drawDeltaTime);
        //}

        private void OnGUI()
        {
            _guiDeltaTime = Time.deltaTime;
            _controllersExecutor.GuiExecute(_guiDeltaTime);
        }

        private void OnDestroy()
        {
            _controllersExecutor.Cleanup();
        }
    }
}