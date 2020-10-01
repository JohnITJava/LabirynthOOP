using UnityEngine;
using System;


namespace BallLabirynthOOP
{

    [Serializable]
    public sealed class PlayerBall : Player
    {
        public GameObject Ball;

        private DisplayBonuses _displayBonuses;

        //In future we will suppose point ~ hp
        private int _bonusPoints;

        public PlayerBall(GameObject ball, float speed, Vector3 startPosition)
        {
            Ball = ball;
            Speed = speed;
            StartPosition = startPosition;
            Rigidbody = ball.GetComponent<Rigidbody>();
            _displayBonuses = new DisplayBonuses();
        }


        public int Points
        {
            get => _bonusPoints;
            set
            {
                _displayBonuses.PrepareInfoMessage(value);
                _displayBonuses.Display();
                _bonusPoints += value;               
            }
        }


        private event EventHandler<BonusChangeEventArgs> _onBonusChangeSigners;
        public event EventHandler<BonusChangeEventArgs> OnBonusPointsChange
        {
            add { _onBonusChangeSigners += value; }
            remove { _onBonusChangeSigners -= value; }
        }

        public void EventSignersInvoke(InteractiveObject obj)
        {
            _onBonusChangeSigners?.Invoke(this, new BonusChangeEventArgs(obj));
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
