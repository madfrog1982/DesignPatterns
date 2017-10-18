namespace SimpleFactoryPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:食物工厂]
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
    public class FoodSimpleFactory
    {
        /// <summary>
        /// 生产食物
        /// </summary>
        /// <param name="type">菜品</param>
        /// <returns></returns>
        public static Food CreateFood(string type)
        {
            Food food = null;
            if (type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            else if (type.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambledEggs();
            }
            return food;
        }
    }
}
