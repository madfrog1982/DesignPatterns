using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 手机挂件
    /// </summary>
    public class Accessories : Decorator
    {
        public Accessories(Phone p) : base(p) { }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddAccessories();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddAccessories()
        {
            Console.WriteLine("苹果手机挂件");
        }
    }
}
