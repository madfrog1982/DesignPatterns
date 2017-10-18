using System;

namespace BridgePattern
{
    public class SamSung : TV
    {
        public override void On()
        {
            Console.WriteLine("三星牌电视机已经打开");
        }

        public override void Off()
        {
            Console.WriteLine("三星牌电视机已经关掉");
        }

        public override void Channel()
        {
            Console.WriteLine("三星牌电视机换频道");
        }
    }
}
