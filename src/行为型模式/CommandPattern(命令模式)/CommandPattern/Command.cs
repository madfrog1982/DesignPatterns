namespace CommandPattern
{
    public abstract class Command
    {
        /// <summary>
        /// 命令应该知道接收者是谁，所以有Receiver这个成员变量。
        /// </summary>
        protected Receiver _receiver;

        protected Command(Receiver receiver)
        {
            this._receiver = receiver;
        }

        /// <summary>
        /// 命令执行方法
        /// </summary>
        public abstract void Action();
    }
}
