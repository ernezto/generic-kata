namespace GenericStack
{
    public class IntStack
    {
        private int[] items;
        private int size;
        private int index;

        public IntStack()
        {
            size = 2;
            items = new int[size];
            index = 0;
        }

        public void Push(int element)
        {
            items[index++] = element;
        }

        public int Top()
        {
            return items[index - 1];
        }
    }
}