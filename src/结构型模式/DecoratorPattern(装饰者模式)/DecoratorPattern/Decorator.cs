namespace DecoratorPattern
{
    /// <summary>
    /// 装饰抽象类，要让装饰完全取代抽象组件，所以必须继承自Phone。
    /// </summary>
    public abstract class Decorator : Phone
    {
        private readonly Phone _phone;

        protected Decorator(Phone p)
        {
            this._phone = p;
        }

        public override void Print()
        {
            _phone?.Print();
        }
    }
}
