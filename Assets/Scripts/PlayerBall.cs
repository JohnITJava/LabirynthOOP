using UnityEngine;
using System;


namespace BallLabirynthOOP
{

    [Serializable]
    public sealed class PlayerBall : Player
    {
        public GameObject Ball;
        public Camera MainCamera;

        public PlayerBall(GameObject ball, float speed, Vector3 startPosition)
        {
            Ball = ball;
            Speed = speed;
            StartPosition = startPosition;
            Rigidbody = ball.GetComponent<Rigidbody>();
        }


        public override void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(-moveHorizontal, 0.0f, -moveVertical);
            var rigidBody = Ball.GetComponent<Rigidbody>();
            rigidBody.AddForce(movement * Speed);
        }
    }
}
