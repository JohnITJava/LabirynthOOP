using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    internal sealed class EnemyMoveController : IUpdateble, IFixedUpdateble
    {
        private readonly IEnemyMove _movebleGroup;
        
        internal EnemyMoveController(IEnemyMove movebleObj)
        {
            _movebleGroup = movebleObj;
        }

        public void Execute(float deltaTime)
        {
            _movebleGroup.Move();
        }

        public void FixedExecute(float deltaTime)
        {
            _movebleGroup.OnTrigger();
        }
    }
}
