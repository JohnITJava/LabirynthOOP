using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class MainController : MonoBehaviour
    {

        [SerializeField] private PlayerBallData _playerBallData;
        [SerializeField] private BonusCubeData _bonusCubeData;

        private List<IUpdateble> _iUpdatables = new List<IUpdateble>();
        private List<IUpdateble> _lateUpdatables = new List<IUpdateble>();
        private List<FixedUpdateble> _fixedUpdatables = new List<FixedUpdateble>();

        private List<InteractiveObject> _interactiveObjects = new List<InteractiveObject>();


        private void Start()
        {
            new InitializeController(this, _playerBallData, _bonusCubeData);
        }

        private void Update()
        {
            for (int i = 0; i < _iUpdatables.Count; i++)
            {
                _iUpdatables[i].UpdateTick();
            }
        }

        private void LateUpdate()
        {
            for (int i = 0; i < _lateUpdatables.Count; i++)
            {
                _lateUpdatables[i].UpdateTick();
            }
        }

        private void FixedUpdate()
        {
            for (int i = 0; i < _fixedUpdatables.Count; i++)
            {
                _fixedUpdatables[i].UpdateTick();
            }
        }

        public void AddUpdatable(IUpdateble updateble)
        {
            _iUpdatables.Add(updateble);
        }

        public void AddLateUpdatable(IUpdateble updateble)
        {
            _lateUpdatables.Add(updateble);
        }

        public void AddFixedUpdatable(FixedUpdateble updateble)
        {
            _fixedUpdatables.Add(updateble);
        }

    }
}