using System;

namespace CompositePattern.Safety
{
    public class Line : Graphics
    {
        public Line(string name) : base(name) { }

        /// <summary>
        /// 重写父类抽象方法
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("画" + Name);
        }
    }
}
