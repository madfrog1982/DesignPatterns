namespace BuilderPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:指挥者]
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
    public class Director
    {
        /// <summary>
        /// 让谁去组装
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartMainBoard();
        }
    }
}
