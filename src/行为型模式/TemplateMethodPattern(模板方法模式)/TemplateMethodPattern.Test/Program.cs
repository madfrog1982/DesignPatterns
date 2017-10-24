using System;

namespace TemplateMethodPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Spinach spinach = new Spinach();
            spinach.CookVegetabel();

            Console.Read();
        }
    }
}
