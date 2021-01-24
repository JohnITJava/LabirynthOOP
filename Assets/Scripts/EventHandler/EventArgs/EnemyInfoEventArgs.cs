using System;


namespace BallLabirynthOOP
{
    public sealed class EnemyInfoEventArgs : EventArgs
    {
        private EnemyInfo _info { get; }

        public EnemyInfoEventArgs(EnemyInfo obj)
        {
            _info = obj;
        }
    }
}
