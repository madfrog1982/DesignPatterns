using System;

namespace SingletonPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:单例模式实现]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-12]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-12]
    /// <说明>
    ///     [内容:
    ///     ⒈using .NET 4's Lazy<T> type
    ///     使用.net 4懒惰<T> 类型]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Singleton07
    {
        private static readonly Lazy<Singleton07> Lazy = new Lazy<Singleton07>(() => new Singleton07());

        public static Singleton07 Instance
        {
            get
            {
                return Lazy.Value;
            }
        }

        private Singleton07() { }
    }
}
