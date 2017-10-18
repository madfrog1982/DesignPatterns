using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 苹果手机
            Phone phone = new ApplePhone();

            // 苹果手机贴膜
            Decorator applePhoneWithSticker = new Sticker(phone);
            // 扩展贴膜行为
            applePhoneWithSticker.Print();

            Console.WriteLine("————————————");

            // 苹果手机挂件
            Decorator applePhoneWithAccessories = new Accessories(phone);
            // 扩展手机挂件行为
            applePhoneWithAccessories.Print();

            Console.WriteLine("————————————");

            // 同时贴膜和手机挂件
            Sticker sticker = new Sticker(phone);
            Accessories applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
            applePhoneWithAccessoriesAndSticker.Print();

            Console.ReadLine();
        }
    }
}
