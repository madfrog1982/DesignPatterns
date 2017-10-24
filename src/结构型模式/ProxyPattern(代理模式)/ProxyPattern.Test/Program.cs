using System;

namespace ProxyPattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person proxy = new Friend();
            proxy.BuyProduct();
            Console.Read();
        }
    }
}
