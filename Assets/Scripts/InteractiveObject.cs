using System;
using UnityEngine;
using Random = UnityEngine.Random;


namespace BallLabirynthOOP
{
    public abstract class InteractiveObject : IInteractable, IComparable<InteractiveObject>
    {

        protected IView _view;

        bool IInteractable.IsInteractable { get; } = true;

        public abstract void Interaction();

        public abstract void Action();

        public abstract int CompareTo(InteractiveObject other);

        public abstract void Initialize(IView view);
    }
}
