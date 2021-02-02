using System.IO;
using UnityEngine;
using static BallLabirynthOOP.LabirynthConstants;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    public sealed class Data : ScriptableObject
    {

        [SerializeField] private string _playerDataPath = PlayerBallDataPath;
        [SerializeField] private string _bonusCubeDataPath = BonusCubeDataPath;
        [SerializeField] private string _cameraDataPath = CameraDataPath;

        private PlayerBallData _playerBallData;
        private BonusCubeData _bonusCubeData;
        private CameraData _cameraData;


        public PlayerBallData PlayerData
        {
            get
            {
                if (_playerBallData == null)
                {
                    _playerBallData = Load<PlayerBallData>(DataPath + _playerDataPath);
                }

                return _playerBallData;
            }
        }

        public BonusCubeData BonusCubeData
        {
            get
            {
                if (_bonusCubeData == null)
                {
                    _bonusCubeData = Load<BonusCubeData>(DataPath + _bonusCubeDataPath);
                }

                return _bonusCubeData;
            }
        }

        public CameraData CameraData
        {
            get
            {
                if (_cameraData == null)
                {
                    _cameraData = Load<CameraData>(DataPath + _cameraDataPath);
                }

                return _cameraData;
            }
        }


        private T Load<T>(string resoursePath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resoursePath, null));
    }
}
