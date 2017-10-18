using System.Collections;

namespace FlyweightPattern
{
    public class FlyweightFactory
    {
        // 最好使用泛型Dictionary<string,Flyweighy>
        // public Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
        public Hashtable Flyweights = new Hashtable();

        public FlyweightFactory()
        {
            Flyweights.Add("A", new ConcreteFlyweight("A"));
            Flyweights.Add("B", new ConcreteFlyweight("B"));
            Flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            // 更好的实现如下
            //Flyweight flyweight = flyweights[key] as Flyweight;
            //if (flyweight == null)
            //{
            // Console.WriteLine("驻留池中不存在字符串" + key);
            // flyweight = new ConcreteFlyweight(key);
            //}
            //return flyweight;

            return Flyweights[key] as Flyweight;
        }
    }
}
