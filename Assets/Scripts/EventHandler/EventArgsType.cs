using System;
using System.Collections;


namespace BallLabirynthOOP
{
    public sealed class EventArgsType<T> : IEnumerator, IEnumerable where T : EventArgs
    {
        public T EventTypeObject { get; }

        public object Current => throw new NotImplementedException();

        public EventArgsType(T obj)
        {
            EventTypeObject = obj;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
