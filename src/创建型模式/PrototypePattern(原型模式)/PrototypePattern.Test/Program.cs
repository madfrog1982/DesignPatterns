using System;

namespace PrototypePattern.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyKingPrototype prototypeMonkeyKing = new ConcretePrototype("MonkeyKing");

            MonkeyKingPrototype cloneMonkeyKing1 = prototypeMonkeyKing.Clone() as ConcretePrototype;
            Console.WriteLine("Clone1:\t" + cloneMonkeyKing1?.Id);

            MonkeyKingPrototype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcretePrototype;
            Console.WriteLine("Clone2:\t" + cloneMonkeyKing2?.Id);

            prototypeMonkeyKing.Id = "MonkeyKingNew";

            // 当前对象的非静态字段复制到该新对象。如果字段是值类型的，则对该字段执行逐位复制。如果字段是引用类型，则复制引用但不复制引用的对象。因此，原始对象及其复本引用的是同一对象。
            Console.WriteLine("CloneNew1:\t" + cloneMonkeyKing1?.Id);
            Console.WriteLine("CloneNew2:\t" + cloneMonkeyKing2?.Id);

            Console.WriteLine("Clone3:\t" + prototypeMonkeyKing.Id);

            Console.ReadLine();
        }
    }
}
