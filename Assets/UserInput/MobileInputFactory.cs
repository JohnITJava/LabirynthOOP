using UnityEngine;
using UnityEngine.UI;


namespace BallLabirynthOOP
{
    internal sealed class MobileInputFactory : IMobileInputFactory
    {
        private readonly Transform _root;
        private readonly Button _gameObject;

        internal MobileInputFactory(Transform root, Button gameObject)
        {
            _root = root;
            _gameObject = gameObject;
        }

        public Button Create()
        {
            return Object.Instantiate(_gameObject, _root);
        }
    }
}
