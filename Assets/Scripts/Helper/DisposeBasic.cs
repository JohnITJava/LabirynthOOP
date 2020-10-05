using System;


namespace BallLabirynthOOP
{
    public abstract class DisposeBasic : IDisposable
    {
        protected bool _disposed;

        ~DisposeBasic()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Dispose(bool disposing)
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
    }
}
