using System;

namespace FlyweightPattern
{
    public class ConcreteFlyweight : Flyweight
    {
        /// <summary>
        /// 内部状态
        /// </summary>
        private readonly string _intrinsicstate;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="innerState"></param>
        public ConcreteFlyweight(string innerState)
        {
            this._intrinsicstate = innerState;
        }

        /// <summary>
        /// 享元类的实例方法
        /// </summary>
        /// <param name="extrinsicstate">外部状态</param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体实现类：intrinsicstate {0}, extrinsicstate {1}", _intrinsicstate, extrinsicstate);
        }
    }
}
