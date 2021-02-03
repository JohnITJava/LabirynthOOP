using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class MobileInput : IUserInputProxy
    {
        public event Action<float> AxisOnChange;

        public void GetAxis()
        {
            Debug.Log("Axis Button Pressed");
        }
    }
}
