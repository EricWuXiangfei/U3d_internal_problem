namespace Core
{
    public interface IStateNode
    {
        /// <summary>
        /// 状态创建时
        /// </summary>
        /// <param name="stateMachine"></param>
        void OnCreate();
        /// <summary>
        /// 进入状态时
        /// </summary>
        void OnEnter();
        /// <summary>
        /// 状态循环
        /// </summary>
        void OnUpdate();
        /// <summary>
        /// 状态退出
        /// </summary>
        void OnExit();
    }
}
