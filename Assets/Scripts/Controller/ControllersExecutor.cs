using System.Collections.Generic;


namespace BallLabirynthOOP
{
    internal sealed class ControllersExecutor : IInizialization, IUpdateble, ILateUpdateble, IFixedUpdateble, IDrawUpdateble, IGuiUpdateble, ICleanup
    {
        private List<IInizialization> _inizializators;
        private List<IUpdateble> _iUpdatables;
        private List<ILateUpdateble> _lateUpdatables;
        private List<IFixedUpdateble> _fixedUpdatables;
        private List<IDrawUpdateble> _drawUpdatebles;
        private List<IGuiUpdateble> _iGuiUpdatebles;
        private List<ICleanup> _iCleanups;


        internal ControllersExecutor()
        {
            _inizializators = new List<IInizialization>();
            _iUpdatables = new List<IUpdateble>();
            _lateUpdatables = new List<ILateUpdateble>();
            _fixedUpdatables = new List<IFixedUpdateble>();
            _drawUpdatebles = new List<IDrawUpdateble>();
            _iGuiUpdatebles = new List<IGuiUpdateble>();
            _iCleanups = new List<ICleanup>();
        }

        internal ControllersExecutor Add(IController controller)
        {
            if (controller is IInizialization inizializator)
            {
                _inizializators.Add(inizializator);
            }

            if (controller is IUpdateble updateble)
            {
                _iUpdatables.Add(updateble);
            }

            if (controller is ILateUpdateble lateUpdateble)
            {
                _lateUpdatables.Add(lateUpdateble);
            }

            if (controller is IFixedUpdateble fixedUpdateble)
            {
                _fixedUpdatables.Add(fixedUpdateble);
            }

            if (controller is IDrawUpdateble drawUpdateble)
            {
                _drawUpdatebles.Add(drawUpdateble);
            }

            if (controller is IGuiUpdateble guiUpdateble)
            {
                _iGuiUpdatebles.Add(guiUpdateble);
            }

            if (controller is ICleanup cleanup)
            {
                _iCleanups.Add(cleanup);
            }

            return this;
        }


        public void Initialization()
        {
            for (var index = 0; index < _inizializators.Count; ++index)
            {
                _inizializators[index].Initialization();
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < _iUpdatables.Count; i++)
            {
                _iUpdatables[i].Execute(deltaTime);
            }
        }

        public void LateExecute(float deltaTime)
        {
            for (int i = 0; i < _lateUpdatables.Count; i++)
            {
                _lateUpdatables[i].LateExecute(deltaTime);
            }
        }

        public void FixedExecute(float deltaTime)
        {
            for (int i = 0; i < _fixedUpdatables.Count; i++)
            {
                _fixedUpdatables[i].FixedExecute(deltaTime);
            }
        }

        public void DrawExecute(float deltaTime)
        {
            for (int i = 0; i < _drawUpdatebles.Count; i++)
            {
                _drawUpdatebles[i].DrawExecute(deltaTime);
            }
        }

        public void GuiExecute(float deltaTime)
        {
            for (int i = 0; i < _iGuiUpdatebles.Count; i++)
            {
                _iGuiUpdatebles[i].GuiExecute(deltaTime);
            }
        }

        public void Cleanup()
        {
            for (var index = 0; index < _iCleanups.Count; ++index)
            {
                _iCleanups[index].Cleanup();
            }
        }

    }
}
