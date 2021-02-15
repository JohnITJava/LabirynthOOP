using UnityEngine;
using System;


namespace BallLabirynthOOP
{

    [Serializable]
    public sealed class PlayerBall : PlayerBase
    {
        public GameObject Ball;

        public float StartedHPBonus = 100.0f;


        private event EventHandler<EventTypeCast<InteractiveObject>> _onBonusChangeSigners;
        private event Action<EnemyInfo> _onDamageCaughtSigners = delegate (EnemyInfo enemyInfo) { };

        private DisplayBonus _displayBonuses;

        //In future we will suppose point ~ hp
        private float _bonusPoints;


        public PlayerBall(GameObject ball, float speed, Vector3 startPosition) : base(ball.GetComponent<Rigidbody>())
        {
            Ball = ball;
            Speed = speed;
            StartPosition = startPosition;
            _bonusPoints = StartedHPBonus;
            _displayBonuses = new DisplayBonus(this);
        }

        public event EventHandler<EventTypeCast<InteractiveObject>> OnBonusPointsChangeEvent
        {
            add { _onBonusChangeSigners += value; }
            remove { _onBonusChangeSigners -= value; }
        }

        public event Action<EnemyInfo> OnDamageCaughtEvent
        {
            add { _onDamageCaughtSigners += value; }
            remove { _onDamageCaughtSigners -= value; }
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

        public void EventSignersInvoke(InteractiveObject cube)
        {
            _onBonusChangeSigners?.Invoke(this, new EventTypeCast<InteractiveObject>(cube));

            BonusCube bonusCube = (BonusCube)cube;

            _onDamageCaughtSigners.Invoke(new EnemyInfo(
                bonusCube.GetType(),
                bonusCube.BonusCubeObject.GetInstanceID().ToString(),
                bonusCube.BonusCubeObject.GetComponent<Renderer>().material.color));
        }


        public override void Move(float horizontal, float vertical)
        {
            base.Move(horizontal, vertical);

            Vector3 movement = new Vector3(-_moveHorizontal, 0.0f, -_moveVertical);   
            var rigidBody = Ball.GetComponent<Rigidbody>();
            rigidBody.AddForce(movement * Speed);
        }
    }
}
