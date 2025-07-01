namespace Core
{
    public abstract class BaseStateNode : IStateNode
    {
        public void OnCreate()
        {
        }

        protected internal abstract void OnEnter();
        protected internal abstract void OnExit();
        protected internal abstract void OnUpdate();

        void IStateNode.OnEnter() => OnEnter();
        void IStateNode.OnExit() => OnExit();

        void IStateNode.OnUpdate() => OnUpdate();
    }
}
