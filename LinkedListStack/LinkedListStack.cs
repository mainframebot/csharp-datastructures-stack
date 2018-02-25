using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListStack
{
    public class LinkedListStack<T> : IEnumerable<T>
    {
        private LinkedList<T> _linkedList = new LinkedList<T>();

        public int Count { get { return _linkedList.Count; } }

        public void Push(T value)
        {
            _linkedList.AddFirst(value);
        }

        public T Pop()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException();

            var value = _linkedList.First.Value;
            _linkedList.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException();

            return _linkedList.First.Value;
        }

        public void Clear()
        {
            _linkedList.Clear();
        }

        #region IEnumerable<T> Interface Implementation

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        #endregion

    }
}
