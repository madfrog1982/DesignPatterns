using System;

namespace IteratorPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IListCollection list = new ConcreteList();
            Iterator iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }

            Console.Read();
        }
    }
}
