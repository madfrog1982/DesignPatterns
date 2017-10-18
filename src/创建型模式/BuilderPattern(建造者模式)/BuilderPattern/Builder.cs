namespace BuilderPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:建造者抽象类]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-16]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-16]
    /// <说明>
    ///     [内容:]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 装CPU
        /// </summary>
        public abstract void BuildPartCPU();

        /// <summary>
        /// 装主板
        /// </summary>
        public abstract void BuildPartMainBoard();

        /// <summary>
        /// 获取组装好的电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }
}
