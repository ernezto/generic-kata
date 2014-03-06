using System;

namespace GenericStack
{
    public class Stack<T>
    {
        private T[] items;
        private int index;

        public int Capacity { get; private set; }

        public Stack(int capacity)
        {
            Capacity = capacity;
            items = new T[Capacity];
            index = 0;
        }

        public void Push(T element)
        {
            if (index == Capacity)
                throw new InvalidOperationException();
            items[index++] = element;
        }

        public T Top()
        {
            if (index == 0 ) throw new InvalidOperationException();

            return items[--index];
        }
    }
}