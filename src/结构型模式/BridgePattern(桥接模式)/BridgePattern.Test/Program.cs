using System;

namespace BridgePattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个遥控器
            RemoteControl remoteControl = new ConcreteRemote();

            // 长虹电视机
            remoteControl.Implementor = new ChangHong();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();

            Console.WriteLine("————————————");

            // 三星牌电视机
            remoteControl.Implementor = new SamSung();
            remoteControl.On();
            remoteControl.SetChannel();
            remoteControl.Off();

            Console.Read();
        }
    }
}
