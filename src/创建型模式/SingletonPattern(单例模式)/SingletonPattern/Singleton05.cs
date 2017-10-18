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
    ///     ⒈not quite as lazy, but thread-safe without using locks
    ///     不是很懒，但不使用锁的线程安全
    ///     静态初始化
    ///     该类标记为 sealed 以阻止发生派生，而派生可能会增加实例。]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public sealed class Singleton05
    {
        private static readonly Singleton05 instance = new Singleton05();

        public static Singleton05 Instance
        {
            get
            {
                return instance;
            }
        }

        private Singleton05() { }

        static Singleton05() { }
    }
}
