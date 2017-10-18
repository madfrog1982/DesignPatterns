using System;

namespace CompositePattern.Transparent
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

        public override void Add(Graphics g)
        {
            //throw new NotImplementedException();
            throw new Exception("不能向简单图形Line添加其它图形");
        }

        public override void Remove(Graphics g)
        {
            //throw new NotImplementedException();
            throw new Exception("不能向简单图形Line添加其它图形");
        }
    }
}
