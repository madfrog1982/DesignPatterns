using System;

namespace BridgePattern
{
    public class ChangHong : TV
    {
        public override void On()
        {
            Console.WriteLine("长虹牌电视机已经打开");
        }

        public override void Off()
        {
            Console.WriteLine("长虹牌电视机已经关掉");
        }

        public override void Channel()
        {
            Console.WriteLine("长虹牌电视机换频道");
        }
    }
}
