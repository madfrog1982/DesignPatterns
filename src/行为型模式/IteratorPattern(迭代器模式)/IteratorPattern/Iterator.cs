using System;

namespace IteratorPattern
{
    public interface Iterator
    {
        bool MoveNext();

        Object GetCurrent();

        void Next();

        void Reset();
    }
}
