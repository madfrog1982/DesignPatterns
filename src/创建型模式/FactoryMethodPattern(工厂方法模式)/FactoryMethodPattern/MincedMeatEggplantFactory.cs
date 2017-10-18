namespace FactoryMethodPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:肉末茄子工厂]
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
    public class MincedMeatEggplantFactory : Creator
    {
        /// <summary>
        /// 创建肉末茄子
        /// </summary>
        /// <returns></returns>
        public override Food CreateFoodFactory()
        {
            return new MincedMeatEggplant();
        }
    }
}
