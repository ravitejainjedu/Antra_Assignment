using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class CustomList<T>
    {
        private T[] _items = new T[4];    // initial capacity
        private int _count;               // current size

        // adds to end
        public void Add(T element)
        {
            if (_count == _items.Length)
                Array.Resize(ref _items, _items.Length * 2);

            _items[_count++] = element;
        }

        // removes and returns element at index
        public T Remove(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException();

            T removed = _items[index];
            // shift left
            for (int i = index; i < _count - 1; i++)
                _items[i] = _items[i + 1];

            _items[--_count] = default;
            return removed;
        }

        // checks for existence
        public bool Contains(T element)
        {
            for (int i = 0; i < _count; i++)
                if (Equals(_items[i], element))
                    return true;

            return false;
        }

        // clears the list
        public void Clear()
        {
            for (int i = 0; i < _count; i++)
                _items[i] = default;

            _count = 0;
        }

        // inserts at specific index
        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > _count)
                throw new ArgumentOutOfRangeException();

            if (_count == _items.Length)
                Array.Resize(ref _items, _items.Length * 2);

            for (int i = _count; i > index; i--)
                _items[i] = _items[i - 1];

            _items[index] = element;
            _count++;
        }

        // deletes at index (same as Remove but void)
        public void DeleteAt(int index)
        {
            Remove(index);
        }

        // returns element at index
        public T Find(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException();

            return _items[index];
        }
    }
}
