﻿namespace AbstractFactoryPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:抽象工厂类，提供创建两个不同地方的鸭架和鸭脖的接口。]
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
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();

        public abstract YaJia CreateYaJia();
    }
}
