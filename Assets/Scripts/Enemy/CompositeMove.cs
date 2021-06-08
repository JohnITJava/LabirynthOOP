using System.Collections.Generic;


namespace BallLabirynthOOP
{
    internal sealed class CompositeMove : IEnemyMove
    {
        private List<IEnemyMove> _moves = new List<IEnemyMove>();

        public void AddUnit(IEnemyMove unit)
        {
            _moves.Add(unit);
        }

        public void RemoveUnit(IEnemyMove unit)
        {
            _moves.Remove(unit);
        }

        public void Move()
        {
            for (int i = 0; i < _moves.Count; i++)
            {
                _moves[i].Move();
            }
        }

        public void OnTrigger()
        {
            for (int i = 0; i < _moves.Count; i++)
            {
                _moves[i].OnTrigger();
            }
        }

    }
}
