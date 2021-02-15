using System;
using System.Collections;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public abstract class InteractiveObject : DisposeBasic, IInteractable, IFly, IFlicker, IRotation, IComparable, IIteratable<InteractiveObject>
    {
        private static List<InteractiveObject> _allInteractives = new List<InteractiveObject>();
        private int _index = -1;
        private InteractiveObject _current;

        public event Action<InteractiveObject> OnDestroyChange;
        //public event Action<InteractiveObject> OnDestroyChange;

        public bool IsInteractable { get; } = true;

        public InteractiveObject this[int index]
        {
            get => _allInteractives[index];
            set => _allInteractives[index] = value;
        }

        public InteractiveObject() { }

        public InteractiveObject(List<InteractiveObject> interactives)
        {
            _allInteractives.AddRange(interactives);
            _allInteractives.Sort();
        }

        public InteractiveObject Current => _current;

        public int Count => _allInteractives.Count;


        object IEnumerator.Current => _allInteractives[_index];

        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    //Free controlled resources
                }

                //Free uncontrolled resources
                _disposed = true;
            }

        }

        public void OnTriggerEnter()
        {
            OnDestroyChange?.Invoke(this);
            Action();
        }

        public abstract void Interaction();

        public abstract void Action();

        public abstract int CompareTo(object obj);

        public abstract void Fly();

        public abstract void Flick();

        public abstract void Rotate();


        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            if (_index == _allInteractives.Count - 1)
            {
                Reset();
                return false;
            }

            _index++;
            return true;
        }

        public void Reset() => _index = -1;


        IEnumerator<InteractiveObject> IEnumerable<InteractiveObject>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public virtual void Initialization() { 
            //throw new NotImplementedException(); 
        }

    }
}
