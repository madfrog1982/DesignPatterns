﻿using System;

namespace FlyweightPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // 定义外部状态，例如字母的位置等信息。
            int externalstate = 10;
            // 初始化享元工厂
            FlyweightFactory factory = new FlyweightFactory();
            // 判断是否已经创建了字母A，如果已经创建就直接使用创建的对象A。
            Flyweight fa = factory.GetFlyweight("A");
            // 把外部状态作为享元对象的方法调用参数
            fa?.Operation(--externalstate);
            // 判断是否已经创建了字母B
            Flyweight fb = factory.GetFlyweight("B");
            fb?.Operation(--externalstate);
            // 判断是否已经创建了字母C
            Flyweight fc = factory.GetFlyweight("C");
            fc?.Operation(--externalstate);
            // 判断是否已经创建了字母D
            Flyweight fd = factory.GetFlyweight("D");
            if (fd != null)
            {
                fd.Operation(--externalstate);
            }
            else
            {
                Console.WriteLine("驻留池中不存在字符串D");
                // 这时候就需要创建一个对象并放入驻留池中
                ConcreteFlyweight d = new ConcreteFlyweight("D");
                factory.Flyweights.Add("D", d);
            }

            Console.Read();
        }
    }
}
