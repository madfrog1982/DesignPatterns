using System;

namespace BridgePattern
{
    public class ConcreteRemote : RemoteControl
    {
        public override void SetChannel()
        {
            Console.WriteLine("-————————————");
            base.SetChannel();
            Console.WriteLine("-————————————");
        }
    }
}
