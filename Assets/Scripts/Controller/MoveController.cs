using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class MoveController : IUpdateble, ICleanup
    {
        private readonly IMove _unit;
        private readonly IUnit _unitData;
        private Vector3 _move;
        private IUserInputProxy _horizontalInputProxy;
        private IUserInputProxy _verticalInputProxy;

        private float _horizontal;
        private float _vertical;

        internal MoveController((IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) input, IUnit unitData, IMove unit)
        {
            _unitData = unitData;
            _unit = unit;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisOnChange;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        private void VerticalOnAxisOnChange(float value)
        {
            _vertical = value;
        }

        public void Execute(float deltaTime)
        {
            _unit.Move(_horizontal, _vertical);
        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisOnChange;
        }
    }
}
