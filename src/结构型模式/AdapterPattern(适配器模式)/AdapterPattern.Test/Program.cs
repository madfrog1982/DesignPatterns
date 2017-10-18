using System;
using AdapterPattern.Class;
using AdapterPattern.Object;
using PowerAdapter = AdapterPattern.Class.PowerAdapter;

namespace AdapterPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Adapter");
            IThreeHole threehole1 = new PowerAdapter();
            threehole1.Request();

            Console.WriteLine("Object Adapter");
            ThreeHole threehole2 = new Object.PowerAdapter();
            threehole2.Request();

            Console.ReadLine();
        }
    }
}
