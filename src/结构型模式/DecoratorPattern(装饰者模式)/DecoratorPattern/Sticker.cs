using System;

namespace DecoratorPattern
{
    /// <summary>
    /// 贴膜，即具体装饰者。
    /// </summary>
    public class Sticker : Decorator
    {
        public Sticker(Phone p) : base(p) { }

        public override void Print()
        {
            base.Print();

            // 添加新的行为
            AddSticker();
        }

        /// <summary>
        /// 新的行为方法
        /// </summary>
        public void AddSticker()
        {
            Console.WriteLine("苹果手机贴膜");
        }
    }
}
