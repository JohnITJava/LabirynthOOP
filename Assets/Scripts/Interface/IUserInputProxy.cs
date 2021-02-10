using System;


namespace BallLabirynthOOP
{
    public interface IUserInputProxy
    {
        event Action<float> AxisOnChange;

        void GetAxis();
    }
}
