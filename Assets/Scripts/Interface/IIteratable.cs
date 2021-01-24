using System.Collections.Generic;

namespace BallLabirynthOOP
{
    public interface IIteratable<T> : IEnumerable<T>, IEnumerator<T>
    {
    }
}
