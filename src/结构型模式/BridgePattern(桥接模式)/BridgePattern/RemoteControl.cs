namespace BridgePattern
{
    public class RemoteControl
    {
        private TV _implementor;

        public TV Implementor
        {
            get { return _implementor; }
            set { _implementor = value; }
        }

        /// <summary>
        /// 开电视机，这里抽象类中不再提供实现了，而是调用实现类中的实现。
        /// </summary>
        public virtual void On()
        {
            _implementor.On();
        }

        /// <summary>
        /// 关电视机
        /// </summary>
        public virtual void Off()
        {
            _implementor.Off();
        }

        /// <summary>
        /// 换频道
        /// </summary>
        public virtual void SetChannel()
        {
            _implementor.Channel();
        }
    }
}
