namespace CommandPattern
{
    /// <summary>
    /// 教官，负责调用命令对象执行请求。
    /// </summary>
    public class Invoke
    {
        public Command _command;

        public Invoke(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Action();
        }
    }
}
