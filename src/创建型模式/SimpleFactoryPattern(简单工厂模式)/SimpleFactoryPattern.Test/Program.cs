using System;

namespace SimpleFactoryPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("非简单工厂模式实现，实现顾客自己在家做菜，顾客和菜之间有耦合。");
            Food food1 = Customer.Cook("西红柿炒蛋");
            food1.Print();
            Food food2 = Customer.Cook("土豆肉丝");
            food2.Print();

            Console.WriteLine("————————————");

            Console.WriteLine("非简单工厂模式实现，要什么菜自己生产，所以和菜之间有耦合。");
            Food food3 = new TomatoScrambledEggs();
            food3.Print();
            Food food4 = new ShreddedPorkWithPotatoes();
            food4.Print();

            Console.WriteLine("————————————");

            Console.WriteLine("简单工厂模式实现，要什么菜有工厂提供，和菜之间没有耦合。");
            Food food5 = FoodSimpleFactory.CreateFood("西红柿炒蛋");
            food5.Print();
            Food food6 = FoodSimpleFactory.CreateFood("土豆肉丝");
            food6.Print();

            Console.Read();
        }
    }
}
