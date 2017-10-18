using System.Threading;

namespace SingletonPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:单例模式实现]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-12]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-12]
    /// <说明>
    ///     [内容:]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Singleton04
    {
        /// <summary>
        /// 定义一个静态变量来保存类实例
        /// 每个线程都有自己的线程栈，定义为静态主要是为了在多线程确保类有一个实例。
        /// </summary>
        private static Singleton04 _uniqueInstance;

        /// <summary>
        /// 定义私有构造函数，使外界不能创建该类实例。
        /// </summary>
        private Singleton04() { }

        // 主要是因为该类不是公有，所以这个全部访问点也定义为私有的了
        // 但是思想还是用到了单例模式的思想的
        private static Singleton04 GetInstancePrivate()
        {
            if (_uniqueInstance != null)
            {
                return _uniqueInstance;
            }

            Singleton04 singleton = new Singleton04();
            Interlocked.CompareExchange(ref _uniqueInstance, singleton, null);

            return _uniqueInstance;
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点，同时你也可以定义公有属性来提供全局访问点。
        /// </summary>
        /// <returns></returns>
        public static Singleton04 GetInstance()
        {
            Singleton04 singleton = GetInstancePrivate();
            return singleton;
        }
    }
}
