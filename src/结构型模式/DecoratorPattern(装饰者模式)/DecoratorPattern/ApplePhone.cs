using System;

namespace DecoratorPattern
{
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("苹果手机");
        }
    }
}
