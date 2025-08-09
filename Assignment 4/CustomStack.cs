using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    public class CustomStack<T>
    {
        private T[] _items = new T[4];     // initial capacity
        private int _count;                // current number of elements

        // returns number of items in the stack
        public int Count()
        {
            return _count;
        }

        // pushes an item onto the top of the stack
        public void Push(T item)
        {
            if (_count == _items.Length) // resize when full
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count++] = item;
        }

        // pops and returns the top item, throws if empty
        public T Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty");

            T top = _items[--_count];
            _items[_count] = default;     // clear reference
            return top;

        }
    }
}
