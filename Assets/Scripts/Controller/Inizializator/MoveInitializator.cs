using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class MoveInitializator : IInizialization
    {
        internal MoveInitializator(ControllersExecutor controllersExecutor, (IUserInputProxy horizontal, IUserInputProxy vertical) input, IUnit untiData, IMove unit)
        {
            controllersExecutor.Add(new MoveController(input, untiData, unit));
        }

        public void Initialization()
        {
            throw new NotImplementedException();
        }
    }
}
