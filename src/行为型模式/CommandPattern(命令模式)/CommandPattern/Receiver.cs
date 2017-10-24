using System;

namespace CommandPattern
{
    /// <summary>
    /// 命令接收者
    /// 学生
    /// </summary>
    public class Receiver
    {
        public void Run1000Meters()
        {
            Console.WriteLine("跑1000米");
        }
    }
}
