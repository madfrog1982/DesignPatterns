namespace AdapterPattern.Class
{
    public class PowerAdapter : TwoHole, IThreeHole
    {
        /// <summary>
        /// 实现三孔插头接口方法
        /// </summary>
        public void Request()
        {
            // 调用两孔插头方法
            this.SpecificRequest();
        }
    }
}
