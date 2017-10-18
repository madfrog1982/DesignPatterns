using System;

namespace FactoryMethodPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:土豆肉丝]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-13]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-13]
    /// <说明>
    ///     [内容:]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        /// <summary>
        /// 输出菜品
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }
}
