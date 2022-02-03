namespace Arrays
{
    internal class Array
    {
        private int[] items;
        private int count;

        public Array(int size)
        {
            items = new int[size];
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void Insert(int element)
        {
            if (count == items.Length)
            {
                var newItems = new int[count * 2];

                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                items = newItems;
            }

            items[count++] = element;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));

            for (int i = index; i < count; i++)
                items[i] = items[i + 1];

            count--;
        }

        public int IndexOf(int element)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == element)
                    return i;
            }

            return -1;
        }

        public int Max()
        {
            var max = 0;
            for (int i = 0; i < count; i++)
            {
                if (items[i] > max)
                    max = items[i];
            }

            return max;
        }

        public int[] Intersect(int[] second)
        {
            var x = new int[count];
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (items[i] == second[j])
                    {
                        x[j] = second[j];
                    }
                }
            }

            return x;
        }

        public int[] Reverse()
        {
            var reverse = new int[count];

            for (int i = 0; i < count; i++)
            {
                reverse[i] = items[(count - 1) - i];
            }

            return reverse;
        }

        public void InsertAt(int element, int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));

            var newArray = new int[count + 1];

            for (int i = index; i < count; i++)
            {
                newArray[i + 1] = items[i];
            }

            items[index] = element;

            items = newArray;

            count++;
        }
    }
}
