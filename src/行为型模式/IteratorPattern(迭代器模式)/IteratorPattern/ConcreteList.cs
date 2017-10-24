namespace IteratorPattern
{
    public class ConcreteList : IListCollection
    {
        private readonly int[] _collection;

        public ConcreteList()
        {
            _collection = new int[] { 2, 4, 6, 8 };
        }

        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return _collection.Length; }
        }

        public int GetElement(int index)
        {
            return _collection[index];
        }
    }
}
