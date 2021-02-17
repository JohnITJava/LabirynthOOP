using System.IO;
using UnityEngine;
using static BallLabirynthOOP.DataPaths;


namespace BallLabirynthOOP
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
    internal sealed class Data : ScriptableObject
    {

        [SerializeField] private string _playerDataPath = PlayerBallDataPath;
        [SerializeField] private string _bonusCubeDataPath = BonusCubeDataPath;
        [SerializeField] private string _cameraDataPath = CameraDataPath;
        [SerializeField] private string _enemyDataPath = EnemyDataPath;

        private PlayerBallData _playerBallData;
        private BonusCubeData _bonusCubeData;
        private CameraData _cameraData;
        private EnemyData _enemyData;


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

        public EnemyData EnemyData
        {
            get
            {
                if (_enemyData == null)
                {
                    _enemyData = Load<EnemyData>(DataPath + _enemyDataPath);
                }

                return _enemyData;
            }
        }

        private T Load<T>(string resoursePath) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(resoursePath, null));
    }
}
