using System;

namespace GenericStack
{
    public class StringStack
    {
        private string[] items;
        private int index;

        public int Capacity { get; private set; }

        public StringStack(int capacity)
        {
            Capacity = capacity;
            items = new string[Capacity];
            index = 0;
        }

        public void Push(string element)
        {
            if (index == Capacity)
                throw new InvalidOperationException();
            items[index++] = element;
        }

        public string Top()
        {
            if (index == 0 ) throw new InvalidOperationException();

            return items[--index];
        }
    }
}