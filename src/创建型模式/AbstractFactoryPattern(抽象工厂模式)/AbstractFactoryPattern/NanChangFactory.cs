namespace AbstractFactoryPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:南昌工厂]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-15]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-15]
    /// <说明>
    ///     [内容:]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class NanChangFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new NanChangYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new NanChangYaJia();
        }
    }
}
