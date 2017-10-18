using System;

namespace AbstractFactoryPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("南昌工厂创建及产品生产。");
            AbstractFactory nanChangFactory = new NanChangFactory();
            YaBo nanChangYabo = nanChangFactory.CreateYaBo();
            nanChangYabo.Print();
            YaJia nanChangYajia = nanChangFactory.CreateYaJia();
            nanChangYajia.Print();

            Console.WriteLine("————————————");

            Console.WriteLine("山海工厂创建及产品生产。");
            AbstractFactory shangHaiFactory = new ShangHaiFactory();
            shangHaiFactory.CreateYaBo().Print();
            shangHaiFactory.CreateYaJia().Print();

            Console.Read();
        }
    }
}
