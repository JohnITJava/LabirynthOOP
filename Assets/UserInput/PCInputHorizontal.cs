﻿using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class PCInputHorizontal : IUserInputProxy
    {
        public event Action<float> AxisOnChange = delegate (float f) { };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisManager.HORIZONTAL));
        }
    }
}
