using System.Collections;
using System.Collections.Generic;


namespace BallLabirynthOOP
{
    public abstract class EventTypeCollection<EventArgsType> : IEnumerable, IEnumerator
    {
        private List<EventArgsType> TypesArgs = new List<EventArgsType>();

        public EventTypeCollection(EventArgsType[] types)
        {
            TypesArgs.AddRange(types);
        }

        public object Current => throw new System.NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
