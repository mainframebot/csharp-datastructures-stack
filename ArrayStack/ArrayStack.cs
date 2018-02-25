using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    public class ArrayStack<T> : IEnumerable<T>
    {
        private T[] _array = new T[0];

        private int _size = 0;

        public int Count { get { return _size; } }

        public void Push(T value)
        {
            if (_size == _array.Length)
            {
                var newSize = _size == 0 ? 10 : _size * 2;
                var newArray = new T[newSize];

                _array.CopyTo(newArray, 0);
                _array = newArray;
            }

            _array[_size] = value;
            _size++;
        }

        public T Pop()
        {
            if(_size == 0)
                throw new IndexOutOfRangeException();

            T value = _array[_size - 1];
            _array[_size - 1] = default(T);

            _size--;

            return value;
        }

        public T Peek()
        {
            if (_size == 0)
                throw new IndexOutOfRangeException();

            return _array[_size - 1];
        }

        public void Clear()
        {
            _array = new T[0];
            _size = 0;
        }

        #region IEnumerable<T> Interface Implementation

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _size - 1; i >= 0; i--)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

    }
}
