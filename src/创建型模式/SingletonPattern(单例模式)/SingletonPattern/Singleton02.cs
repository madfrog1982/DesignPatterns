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
    ///     ⒈simple thread-safety
    ///     简单的线程安全]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Singleton02
    {
        /// <summary>
        /// 定义一个静态变量来保存类实例
        /// 每个线程都有自己的线程栈，定义为静态主要是为了在多线程确保类有一个实例。
        /// </summary>
        private static Singleton02 _uniqueInstance;

        /// <summary>
        /// 定义一个标识确保线程同步
        /// private object Locker = new object();
        /// 微软的官方demo object Locker = new object();
        /// 静态构造函数和实例构造函数，创建时间点不一样。
        /// </summary>
        private static readonly object Locker = new object();

        /// <summary>
        /// 定义私有构造函数，使外界不能创建该类实例。
        /// </summary>
        private Singleton02() { }

        /// <summary>
        /// 定义公有方法提供一个全局访问点，同时你也可以定义公有属性来提供全局访问点。
        /// </summary>
        /// <returns></returns>
        public static Singleton02 GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对Locker对象"加锁"。
            // 当第二个线程运行该方法时，首先检测到Locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁。
            // Locker语句运行完之后(即线程运行完之后)会对该对象"解锁"。
            lock (Locker)
            {
                // 如果类的实例不存在则创建，否则直接返回。
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new Singleton02();
                }
            }

            return _uniqueInstance;
        }
    }
}
