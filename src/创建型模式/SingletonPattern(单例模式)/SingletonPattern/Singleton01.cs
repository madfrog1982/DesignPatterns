namespace SingletonPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:单例模式实现]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-11]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-11]
    /// <说明>
    ///     [内容:
    ///     ⒈not thread-safe
    ///     不是线程安全的]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Singleton01
    {
        /// <summary>
        /// 定义一个静态变量来保存类实例
        /// 每个线程都有自己的线程栈，定义为静态主要是为了在多线程确保类有一个实例。
        /// </summary>
        private static Singleton01 _uniqueInstance;

        /// <summary>
        /// 定义私有构造函数，使外界不能创建该类实例。
        /// </summary>
        private Singleton01() { }

        /// <summary>
        /// 定义公有方法提供一个全局访问点，同时你也可以定义公有属性来提供全局访问点。
        /// </summary>
        /// <returns></returns>
        public static Singleton01 GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回。
            return _uniqueInstance ?? (_uniqueInstance = new Singleton01());
        }
    }
}
