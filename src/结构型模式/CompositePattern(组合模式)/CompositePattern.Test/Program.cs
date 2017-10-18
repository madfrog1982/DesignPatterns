using System;

namespace CompositePattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 透明式组合模式
            Console.WriteLine("透明式组合模式————————————");

            // 组合复杂图形
            CompositePattern.Transparent.Graphics complexGraphics1 = new CompositePattern.Transparent.ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            complexGraphics1.Add(new CompositePattern.Transparent.Line("线段A"));
            CompositePattern.Transparent.Graphics compositeCg1 = new CompositePattern.Transparent.ComplexGraphics("一个圆和一条线组成的复杂图形");
            compositeCg1.Add(new CompositePattern.Transparent.Circle("圆"));
            compositeCg1.Add(new CompositePattern.Transparent.Line("线段B"));
            complexGraphics1.Add(compositeCg1);
            CompositePattern.Transparent.Line l1 = new CompositePattern.Transparent.Line("线段C");
            complexGraphics1.Add(l1);

            // 显示复杂图形画法
            Console.WriteLine("复杂图形绘制如下");
            Console.WriteLine("————————————");
            complexGraphics1.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("————————————");
            Console.WriteLine();

            // 移除一个组件再显示复杂图形画法
            complexGraphics1.Remove(l1);
            Console.WriteLine("移除线段C后，复杂图形的绘制如下。");
            Console.WriteLine("————————————");
            complexGraphics1.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("————————————");

            Console.WriteLine("透明式组合模式————————————");
            #endregion

            #region 安全式组合模式
            Console.WriteLine("安全式组合模式————————————");

            // 组合复杂图形
            CompositePattern.Safety.ComplexGraphics complexGraphics2 = new CompositePattern.Safety.ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
            complexGraphics2.Add(new CompositePattern.Safety.Line("线段A"));
            CompositePattern.Safety.ComplexGraphics compositeCg2 = new CompositePattern.Safety.ComplexGraphics("一个圆和一条线组成的复杂图形");
            compositeCg2.Add(new CompositePattern.Safety.Circle("圆"));
            compositeCg2.Add(new CompositePattern.Safety.Line("线段B"));
            complexGraphics2.Add(compositeCg2);
            CompositePattern.Safety.Line l2 = new CompositePattern.Safety.Line("线段C");
            complexGraphics2.Add(l2);

            // 显示复杂图形画法
            Console.WriteLine("复杂图形绘制如下");
            Console.WriteLine("————————————");
            complexGraphics2.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("————————————");
            Console.WriteLine();

            // 移除一个组件再显示复杂图形画法
            complexGraphics2.Remove(l2);
            Console.WriteLine("移除线段C后，复杂图形的绘制如下。");
            Console.WriteLine("————————————");
            complexGraphics2.Draw();
            Console.WriteLine("复杂图形绘制完成");
            Console.WriteLine("————————————");

            Console.WriteLine("安全式组合模式————————————");

            Console.Read();
            #endregion
        }
    }
}
