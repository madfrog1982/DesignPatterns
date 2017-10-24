using System;

namespace TemplateMethodPattern
{
    public class Spinach : Vegetabel
    {
        public override void PourVegetable()
        {
            Console.WriteLine("倒菠菜进锅中");
        }
    }
}
