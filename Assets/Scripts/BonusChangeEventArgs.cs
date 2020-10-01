using System;

namespace BallLabirynthOOP
{
    public sealed class BonusChangeEventArgs : EventArgs
    {
        public InteractiveObject InteractiveObj { get; }

        public BonusChangeEventArgs(InteractiveObject obj)
        {
            InteractiveObj = obj;
        }
    }
}
