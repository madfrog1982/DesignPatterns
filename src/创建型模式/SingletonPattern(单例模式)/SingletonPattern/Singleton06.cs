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
    ///     ⒈fully lazy instantiation
    ///     完全懒惰的实例化
    ///     延迟初始化]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Singleton06
    {
        private class Nested
        {
            static Nested() { }

            internal static readonly Singleton06 instance = new Singleton06();
        }

        public static Singleton06 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private Singleton06() { }
    }
}
