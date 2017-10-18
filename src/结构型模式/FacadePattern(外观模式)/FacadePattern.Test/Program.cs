using System;

namespace FacadePattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationFacade facade = new RegistrationFacade();

            Console.WriteLine(facade.RegisterCourse("设计模式", "Learning Hard") ? "选课成功" : "选课失败");

            Console.Read();
        }
    }
}
