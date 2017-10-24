namespace CommandPattern
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
               : base(receiver)
        {
        }

        public override void Action()
        {
            // 调用接收的方法，因为执行命令的是学生。
            _receiver.Run1000Meters();
        }
    }
}
