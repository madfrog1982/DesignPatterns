using System;

namespace ProxyPattern
{
    public class Friend : Person
    {
        /// <summary>
        /// 引用真实主题实例
        /// </summary>
        private RealBuyPerson _realSubject;

        public override void BuyProduct()
        {
            Console.WriteLine("通过代理类访问真实实体对象的方法");

            if (_realSubject == null)
            {
                _realSubject = new RealBuyPerson();
            }

            this.PreBuyProduct();
            // 调用真实主题方法
            _realSubject.BuyProduct();
            this.PostBuyProduct();
        }

        /// <summary>
        /// 代理角色执行的一些操作
        /// </summary>
        public void PreBuyProduct()
        {
            // 可能不知一个朋友叫这位朋友带东西，首先这位出国的朋友要对每一位朋友要带的东西列一个清单等。
            Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带Iphone ... ...");
        }

        /// <summary>
        /// 买完东西之后，代理角色需要针对每位朋友需要的对买来的东西进行分类。
        /// </summary>
        public void PostBuyProduct()
        {
            Console.WriteLine("终于买完了，现在要对东西分一下，相机是张三的，Iphone是李四的 ... ...");
        }
    }
}
