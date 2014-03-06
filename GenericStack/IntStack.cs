using System;

namespace GenericStack
{
    public class IntStack
    {
        private int[] items;
        private int index;

        public int Capacity { get; private set; }

        public IntStack(int capacity)
        {
            Capacity = capacity;
            items = new int[Capacity];
            index = 0;
        }

        public void Push(int element)
        {
            if (index == Capacity)
                throw new InvalidOperationException();
            items[index++] = element;
        }

        public int Top()
        {
            if (index == 0 ) throw new InvalidOperationException();

            return items[--index];
        }
    }
}