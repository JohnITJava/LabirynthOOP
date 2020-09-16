using UnityEngine;
using System;


namespace BallLabirynthOOP
{
    [Serializable]
    public class Player
    {

        public Camera MainCamera;
        public Rigidbody Rigidbody;

        public float Speed;
        public Vector3 StartPosition;


        public Player()
        {

        }

        public Player(float speed, Vector3 startPosition)
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