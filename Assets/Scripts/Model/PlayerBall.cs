using UnityEngine;
using System;


namespace BallLabirynthOOP
{

    [Serializable]
    public sealed class PlayerBall : PlayerBase
    {
        public GameObject Ball;

        public float StartedHPBonus = 100.0f;


        private event EventHandler<BonusChangeEventArgs> _onBonusChangeSigners;
        private DisplayBonuses _displayBonuses;

        //In future we will suppose point ~ hp
        private float _bonusPoints;


        public PlayerBall(GameObject ball, float speed, Vector3 startPosition) : base(ball.GetComponent<Rigidbody>())
        {
            Ball = ball;
            Speed = speed;
            StartPosition = startPosition;
            _bonusPoints = StartedHPBonus;
            _displayBonuses = new DisplayBonuses(StartedHPBonus);
        }

        public event EventHandler<BonusChangeEventArgs> OnBonusPointsChangeEvent
        {
            add { _onBonusChangeSigners += value; }
            remove { _onBonusChangeSigners -= value; }
        }

        public float Points
        {
            get => _bonusPoints;
            private set
            {
                var inputPoint = value;                
                _bonusPoints += value;

                _displayBonuses.DisplayBonusInfo(inputPoint, _bonusPoints);
            }
        }

        public void AddBonus(float bonus)
        {
            Points = bonus;
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
