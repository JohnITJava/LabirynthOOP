using System;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using System.Linq;


namespace BallLabirynthOOP
{
    [Serializable]
    public sealed class BonusCube : InteractiveObject, IEquatable<BonusCube>
    {
        public GameObject BonusCubeObject;
        private BonusType _bonusType;
        private BoxCollider _bonusCubeCollider;
        private Renderer _renderer;
        private Material _material;
        private Type _behaviourType;

        private RaycastHit _hit;
        private int _points;
        private float _lengthFlay;
        private float _speedRotation;
        private bool _isTriggered;

        private List<Type> behaviourTypes = new List<Type>() { typeof(IFly), typeof(IFlicker), typeof(IRotation) };

        public bool Trigger
        {
            get => _isTriggered;
            set => _isTriggered = value;
        }

        public BonusCube() { }

        public BonusCube(GameObject cube)
        {
            BonusCubeObject = cube;
            var bonusTypeList = Enum.GetValues(typeof(BonusType)).Cast<BonusType>().ToList();
            var randBonusType = Random.Range(0, bonusTypeList.Count);
            _bonusType = bonusTypeList[randBonusType];
            _material = cube.GetComponent<Renderer>().material;
            _renderer = cube.GetComponent<Renderer>();
            _lengthFlay = Random.Range(1.0f, 5.0f);
            _speedRotation = Random.Range(20.0f, 40.0f);
            _behaviourType = ChooseRandDefaultBehaviour();

            _points = Random.Range(0, 99);
        }

        public Type ChooseRandDefaultBehaviour()
        {
            var randBehaviourChoice = Random.Range(0, behaviourTypes.Count);
            var behavior = behaviourTypes[randBehaviourChoice];
            return behavior;
        }

        public void OnTrigger()
        {
            _isTriggered = Physics.BoxCast(_renderer.bounds.center, _renderer.bounds.extents,
                 Vector3.one, out _hit, BonusCubeObject.transform.rotation, 0.5f, 1 << 8);

            if (_isTriggered && _hit.collider.CompareTag("Player"))
            {
                Debug.Log("Im TRIGGERED");
                this.OnTriggerEnter();            
            }
        }

        public void DrawGizmo()
        {
            Gizmos.color = Color.green;
            //Gizmos.DrawCube(BonusCubeObject.GetComponent<Renderer>().bounds.center, BonusCubeObject.GetComponent<Renderer>().bounds.size);

            //Gizmos.DrawCube(_renderer.bounds.center, _renderer.bounds.size);
        }

        public override void Action()
        {
            if (_bonusType.Equals(BonusType.BadBonus))
            {
                _view.Display(-_points);
            }

            if (_bonusType.Equals(BonusType.GoodBonus))
            {
                _view.Display(_points);
            }

            GameObject.Destroy(BonusCubeObject);
        }

        public override void Interaction()
        {
            if (typeof(IFly).Name.Equals(_behaviourType.Name))
            {
                Fly();
            }

            if (typeof(IFlicker).Name.Equals(_behaviourType.Name))
            {
                Flicker();
            }

            if (typeof(IRotation).Name.Equals(_behaviourType.Name))
            {
                Rotation();
            }
        }

        public override void Fly()
        {
            BonusCubeObject.transform.localPosition = new Vector3(BonusCubeObject.transform.localPosition.x,
            Mathf.PingPong(Time.time, _lengthFlay),
            BonusCubeObject.transform.localPosition.z);
        }

        public override void Flicker()
        {
            if (BonusCubeObject.TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }

            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }

        public override void Rotation()
        {
            BonusCubeObject.transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public override int CompareTo(InteractiveObject other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(BonusCube other)
        {
            bool flag = false;

            if (other == null)
            {
                flag = false;
            }
            if (other.BonusCubeObject.transform.position == this.BonusCubeObject.transform.position)
            {
                flag = true;
            }

            return flag;
        }
    }
}
