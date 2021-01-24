using UnityEngine;
using System;


namespace BallLabirynthOOP
{
    [Serializable]
    public class PlayerBase
    {
        protected Rigidbody _rigidbody;

        public float Speed;
        public Vector3 StartPosition;

        public Rigidbody Rigidbody
        {
            get => _rigidbody;
            set => _rigidbody = value;
        }

        public PlayerBase(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public PlayerBase(float speed, Vector3 startPosition)
        {
            Speed = speed;
            StartPosition = startPosition;
        }


        public virtual void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            Rigidbody.AddForce(movement * Speed);
        }
    }
}