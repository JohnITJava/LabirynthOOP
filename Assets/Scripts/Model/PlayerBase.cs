using UnityEngine;
using System;


namespace BallLabirynthOOP
{
    [Serializable]
    internal class PlayerBase : IMove
    {
        public float Speed;
        public Vector3 StartPosition;

        protected Rigidbody _rigidbody;

        protected float _moveHorizontal;
        protected float _moveVertical;

        public Rigidbody Rigidbody
        {
            get => _rigidbody;
            set => _rigidbody = value;
        }

        internal PlayerBase(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        internal PlayerBase(float speed, Vector3 startPosition)
        {
            Speed = speed;
            StartPosition = startPosition;
        }


        public virtual void Move(float horizontal, float vertical)
        {
            _moveHorizontal = horizontal;
            _moveVertical = vertical;
        }
    }
}