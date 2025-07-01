namespace Core
{
    public interface IStateNode
    {
        /// <summary>
        /// ״̬����ʱ
        /// </summary>
        /// <param name="stateMachine"></param>
        void OnCreate();
        /// <summary>
        /// ����״̬ʱ
        /// </summary>
        void OnEnter();
        /// <summary>
        /// ״̬ѭ��
        /// </summary>
        void OnUpdate();
        /// <summary>
        /// ״̬�˳�
        /// </summary>
        void OnExit();
    }
}
