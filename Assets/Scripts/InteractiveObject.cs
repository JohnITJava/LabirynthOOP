using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace BallLabirynthOOP
{
    public abstract class InteractiveObject : IInteractable, IFly, IFlicker, IRotation, IComparable<InteractiveObject>
    {

        protected IView _view;

        public event Action<InteractiveObject> OnDestroyChange;

        public bool IsInteractable { get; } = true;

        public void OnTriggerEnter()
        {
            OnDestroyChange?.Invoke(this);
            Action();
        }

        public abstract void Interaction();

        public abstract void Action();

        public abstract int CompareTo(InteractiveObject other);

        public virtual void Initialization(IView view)
        {
            _view = view;
        }

        public abstract void Fly();

        public abstract void Flicker();

        public abstract void Rotation();
    }
}
