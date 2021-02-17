using System;


namespace BallLabirynthOOP
{
    internal sealed class GUIDisplayException : Exception
    {
        public object ProblemObject { get; }
        public GUIDisplayException(string message, object problemObject) : base(message)
        {
            ProblemObject = problemObject;
        }
    }
}
