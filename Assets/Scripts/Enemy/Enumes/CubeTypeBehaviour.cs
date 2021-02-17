using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;


namespace BallLabirynthOOP
{
    internal static class CubeTypeBehaviourWrapper
    {
        public enum CubeTypeBehaviour : byte
        {
            IFly = 0,
            IFlicker = 1,
            IRotation = 2
        }

        private static byte GetRandNumOfTypeBehaviour()
        {
            return (byte)Random.Range(0, Enum.GetValues(typeof(CubeTypeBehaviour)).Length);
        }

        public static CubeTypeBehaviour SelectRandCubeBehaviour()
        {
            var behaviourNum = GetRandNumOfTypeBehaviour();
            return (CubeTypeBehaviour)Enum.ToObject(typeof(CubeTypeBehaviour), behaviourNum);
        }

        internal sealed class CubeTypeBehaviourDelegate
        {
            private readonly Dictionary<CubeTypeBehaviour, Action> _actions;
            private InteractiveObject _interactiveObject;

            internal CubeTypeBehaviourDelegate(InteractiveObject interactiveObject)
            {
                _interactiveObject = interactiveObject;

                _actions = new Dictionary<CubeTypeBehaviour, Action>
                {
                    [CubeTypeBehaviour.IFlicker] = _interactiveObject.Flick,
                    [CubeTypeBehaviour.IFly] = _interactiveObject.Fly,
                    [CubeTypeBehaviour.IRotation] = _interactiveObject.Rotate
                };
            }

            public Action this[CubeTypeBehaviour index] => _actions[index];
        }
    }
}
