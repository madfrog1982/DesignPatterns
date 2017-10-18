using System;

namespace FactoryMethodPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("创建西红柿炒蛋工厂及输出菜品");
            Creator tomatoScrambledEggsFactory = new TomatoScrambledEggsFactory();
            Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoodFactory();
            tomatoScrambleEggs.Print();

            Console.WriteLine("————————————");

            Console.WriteLine("创建土豆肉丝工厂及输出菜品");
            Creator shreddedPorkWithPotatoesFactory = new ShreddedPorkWithPotatoesFactory();
            Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoodFactory();
            shreddedPorkWithPotatoes.Print();

            Console.WriteLine("————————————");

            Console.WriteLine("创建肉末茄子工厂及输出菜品");
            Creator minceMeatEggplantFactor = new MincedMeatEggplantFactory();
            Food minceMeatEggplant = minceMeatEggplantFactor.CreateFoodFactory();
            minceMeatEggplant.Print();

            Console.Read();
        }
    }
}
