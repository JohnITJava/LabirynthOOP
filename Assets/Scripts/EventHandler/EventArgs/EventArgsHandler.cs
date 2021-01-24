﻿using System;


namespace BallLabirynthOOP
{
    public sealed class EventArgsHandler<T> where T : EventArgs
    {
        public T InteractiveObj { get; }

        public EventArgsHandler(T obj)
        {
            InteractiveObj = obj;
        }
    }
}
