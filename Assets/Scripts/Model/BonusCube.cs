using System;
using System.Linq;
using UnityEngine;
using static BallLabirynthOOP.CubeTypeBehaviourWrapper;
using Random = UnityEngine.Random;


namespace BallLabirynthOOP
{

    [Serializable]
    public sealed class BonusCube : InteractiveObject, IEquatable<BonusCube>
    {

        public GameObject BonusCubeObject;

        public float FlyMin = 1.0f;
        public float FlyMax = 5.0f;
        public float SpeedRotationMin = 20.0f;
        public float SpeedRotationMax = 40.0f;
        public float PointsMin = 0.0f;
        public float PointsMax = 99.0f;


        private BonusType _bonusType;
        private Renderer _renderer;
        private Material _material;
        private CubeTypeBehaviour _behaviourType;
        private RaycastHit _hit;

        private CubeTypeBehaviourDelegate _cubeTypeBehaviourDelegate;

        private int _points;
        private float _lengthFlay;
        private float _speedRotation;
        private bool _isTriggered;


        public BonusCube() { }

        public BonusCube(GameObject cube)
        {
            BonusCubeObject = cube;
            Initialization(cube);
            _cubeTypeBehaviourDelegate = new CubeTypeBehaviourDelegate(this);
        }

        public BonusType BonusType => _bonusType;

        public int Points => _points;

        private void Initialization(GameObject cube)
        {
            DefineCubeBehaviorType();
            DefineAppearance(cube);
            MovementRangeCalculate();
            DefinePointsAndPolarity();
        }

        private void DefineCubeBehaviorType()
        {
            var bonusTypeList = Enum.GetValues(typeof(BonusType)).Cast<BonusType>().ToList();
            var randBonusType = Random.Range(0, bonusTypeList.Count);
            _bonusType = bonusTypeList[randBonusType];
            _behaviourType = ChooseRandDefaultBehaviour();
        }

        private void DefineAppearance(GameObject cube)
        {
            _material = cube.GetComponent<Renderer>().material;
            _renderer = cube.GetComponent<Renderer>();
        }

        private void MovementRangeCalculate()
        {
            _lengthFlay = Random.Range(FlyMin, FlyMax);
            _speedRotation = Random.Range(SpeedRotationMin, SpeedRotationMax);
        }

        private void DefinePointsAndPolarity()
        {
            var points = (int)Random.Range(PointsMin, PointsMax);
            if (BonusType.Equals(BonusType.BadBonus))
            {
                _points = -points;
            }
            else
            {
                _points = points;
            }
        }


        private CubeTypeBehaviour ChooseRandDefaultBehaviour()
        {
            var behavior = SelectRandCubeBehaviour();
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
            GameObject.Destroy(BonusCubeObject);
        }


        public override void Interaction()
        {
            _cubeTypeBehaviourDelegate[_behaviourType]?.Invoke();
        }


        public override void Fly()
        {
            BonusCubeObject.transform.localPosition = new Vector3(BonusCubeObject.transform.localPosition.x,
            Mathf.PingPong(Time.time, _lengthFlay),
            BonusCubeObject.transform.localPosition.z);
        }


        public override void Flick()
        {
            if (BonusCubeObject.TryGetComponent(out Renderer renderer))
            {
                renderer.material.color = Random.ColorHSV();
            }

            _material.color = new Color(_material.color.r, _material.color.g, _material.color.b, Mathf.PingPong(Time.time, 1.0f));
        }


        public override void Rotate()
        {
            BonusCubeObject.transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }


        public override int CompareTo(object other)
        {
            int compare = 0;

            BonusCube first = this;
            BonusCube second = (BonusCube)other;

            if (second == null && first == null || second.Equals(first))
            {
                compare = 0;
            }
            else if (other == null && this != null || (second.BonusCubeObject.transform.position.magnitude < first.BonusCubeObject.transform.position.magnitude))
            {
                compare = 1;
            }
            else if ((other != null && this == null) || (second.BonusCubeObject.transform.position.magnitude > first.BonusCubeObject.transform.position.magnitude))
            {
                compare = -1;
            }
            return compare;
        }


        public bool Equals(BonusCube other)
        {
            bool flag = false;

            if (other == null)
            {
                flag = false;
            }
            if (this.BonusCubeObject.transform.position == other.BonusCubeObject.transform.position)
            {
                flag = true;
            }

            return flag;
        }
    }
}
