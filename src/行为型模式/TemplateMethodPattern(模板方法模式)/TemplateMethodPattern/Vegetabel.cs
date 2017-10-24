using System;

namespace TemplateMethodPattern
{
    public abstract class Vegetabel
    {
        /// <summary>
        /// 模板方法，不要把模版方法定义为Virtual或abstract方法，避免被子类重写，防止更改流程的执行顺序。
        /// </summary>
        public void CookVegetabel()
        {
            Console.WriteLine("抄菜的一般做法");
            this.PourOil();
            this.HeatOil();
            this.PourVegetable();
            this.StirFry();
        }

        /// <summary>
        /// 第一步倒油
        /// </summary>
        public void PourOil()
        {
            Console.WriteLine("倒油");
        }

        /// <summary>
        /// 第二步把油烧热
        /// </summary>
        public void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }

        /// <summary>
        /// 第三步油热了之后倒蔬菜下去，具体哪种蔬菜由子类决定。
        /// </summary>
        public abstract void PourVegetable();

        /// <summary>
        /// 第四步翻炒
        /// </summary>
        public void StirFry()
        {
            Console.WriteLine("翻炒");
        }
    }
}
