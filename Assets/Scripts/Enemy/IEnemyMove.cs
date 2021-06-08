using System;
using UnityEngine;


namespace BallLabirynthOOP
{
    public interface IEnemyMove
    {
        void Move();

        void OnTrigger();
    }
}
