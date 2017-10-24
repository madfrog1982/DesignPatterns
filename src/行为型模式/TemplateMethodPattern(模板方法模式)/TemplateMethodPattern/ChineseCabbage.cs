using System;

namespace TemplateMethodPattern
{
    public class ChineseCabbage : Vegetabel
    {
        public override void PourVegetable()
        {
            Console.WriteLine("倒大白菜进锅中");
        }
    }
}
