﻿using UnityEngine;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public sealed class MainController : MonoBehaviour
    {

        [SerializeField] private PlayerBallData _playerBallData;
        [SerializeField] private BonusCubeData _bonusCubeData;
        [SerializeField] private CameraData _cameraData;


        private List<IUpdateble> _iUpdatables = new List<IUpdateble>();
        private List<ILateUpdateble> _lateUpdatables = new List<ILateUpdateble>();
        private List<FixedUpdateble> _fixedUpdatables = new List<FixedUpdateble>();
        private List<IDrawUpdateble> _drawUpdatebles = new List<IDrawUpdateble>();
        private List<IGuiUpdateble> _iGuiUpdatebles = new List<IGuiUpdateble>();


        private void Start()
        {
            new InitializeController(this, _playerBallData, _bonusCubeData, _cameraData);
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

        private void OnDrawGizmos()
        {
            for (int i = 0; i < _drawUpdatebles.Count; i++)
            {
                _drawUpdatebles[i].UpdateTick();
            }
        }

        private void OnGUI()
        {
            for (int i = 0; i < _iGuiUpdatebles.Count; i++)
            {
                _iGuiUpdatebles[i].UpdateTick();
            }
        }


        public void AddUpdatable(IUpdateble updateble)
        {
            _iUpdatables.Add(updateble);
        }

        public void AddLateUpdatable(ILateUpdateble updateble)
        {
            _lateUpdatables.Add(updateble);
        }

        public void AddFixedUpdatable(FixedUpdateble updateble)
        {
            _fixedUpdatables.Add(updateble);
        }

        public void AddDrawUpdatable(IDrawUpdateble updateble)
        {
            _drawUpdatebles.Add(updateble);
        }

        public void AddGuiUpdatable(IGuiUpdateble updateble)
        {
            _iGuiUpdatebles.Add(updateble);
        }
    }
}