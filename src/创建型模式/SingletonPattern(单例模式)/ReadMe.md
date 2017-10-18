# 定义

>确保一个类只有一个实例,并提供一个全局访问点。

# 文件说明

>Singleton01.cs：实现最简单的单例模式，多线程的情况下会得到多个Singleton01实例。

>Singleton02.cs：解决01中会得到多个Singleton01实例的问题。

>Singleton03.cs：02代码对于每个线程都会对线程辅助对象Locker加锁之后再判断实例是否存在，对于这个操作完全没有必要的，因为当第一个线程创建了该类的实例之后，后面的线程此时只需要直接判断(_uniqueInstance==null)为假，此时完全没必要对线程辅助对象加锁之后再去判断，所以上面的实现方式增加了额外的开销，损失了性能，为了改进上面实现方式的缺陷，我们只需要在lock语句前面加一句(_uniqueInstance==null)的判断就可以避免锁所增加的额外开销，这种实现方式我们就叫它“双重锁定”。

>Singleton04.cs：使用Interlocked等效实现lock功能。

>Singleton05.cs：not quite as lazy, but thread-safe without using locks，不是很懒，但不使用锁的线程安全，静态初始化。

>Singleton06.cs：fully lazy instantiation，完全懒惰的实例化，延迟初始化。

>Singleton07.cs：using .NET 4's Lazy<T> type，使用.net 4懒惰<T> 类型。

# 其它说明

>类上添加sealed以阻止发生派生，而派生可能会增加实例。