using System;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using System.Linq;


namespace BallLabirynthOOP
{
    [Serializable]
    public sealed class BonusCube : InteractiveObject, IFly, IFlicker, IRotation, IEquatable<BonusCube>
    {
        public GameObject BonusCubeObject;

        private BonusType _bonusType;
        private BoxCollider _bonusCubeCollider;
        private Material _material;
        private int _points;
        private float _lengthFlay;
        private float _speedRotation;
        private bool _isTriggered;

        private List<Type> behaviourTypes = new List<Type>() {typeof(IFly), typeof(IFlicker), typeof(IRotation) };

        public bool Trigger
        {
            get => _isTriggered;
            set => _isTriggered = value;
        }

        public BonusCube() { }

        public BonusCube(GameObject cube)
        {
            var bonusTypeList = Enum.GetValues(typeof(BonusType)).Cast<BonusType>().ToList();
            var randBonusType = Random.Range(0, bonusTypeList.Count);
            _bonusType = bonusTypeList[randBonusType];
            _material = cube.GetComponent<Renderer>().material;
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);

            Gizmos.color = Color.green;
            Action();
        }

        public Type ChooseRandDefaultBehaviour()
        {
            var randBehaviourChoice = Random.Range(0, behaviourTypes.Count);
            var behavior = behaviourTypes[randBehaviourChoice];
            return behavior;
        }

        public void OnTrigger()
        {
            _isTriggered = Physics.CheckBox(BonusCubeObject.GetComponent<Renderer>().bounds.center, BonusCubeObject.GetComponent<Renderer>().bounds.extents);
            Gizmos.DrawCube(BonusCubeObject.GetComponent<Renderer>().bounds.center, BonusCubeObject.GetComponent<Renderer>().bounds.size);        
        }

        public override void Initialize(IView view)
        {
            throw new NotImplementedException();
        }

        public override void Action()
        {
            if (BonusCubeObject.TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }
        }

        public override void Interaction()
        {
            var behaviour = ChooseRandDefaultBehaviour();

            if (behaviour is IFly fly)
            {
                fly.Fly();
            }

            if (behaviour is IFlicker flicker)
            {
                flicker.Flicker();
            }

            if (behaviour is IRotation rotation)
            {
                rotation.Rotation();
            }
        }

        public void Fly()
        {
            BonusCubeObject.transform.localPosition = new Vector3(BonusCubeObject.transform.localPosition.x,
            Mathf.PingPong(Time.time, _lengthFlay),
            BonusCubeObject.transform.localPosition.z);
        }

        public void Flicker()
        {
            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public void Rotation()
        {
            BonusCubeObject.transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public override int CompareTo(InteractiveObject other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(BonusCube other)
        {
            throw new NotImplementedException();
        }
    }
}
