using System;


namespace BallLabirynthOOP
{
    public sealed class EventTypeCast<T> : EventArgs
    {
        public T InteractiveObj { get; }

        public EventTypeCast(T obj)
        {
            InteractiveObj = obj;
        }
    }
}
