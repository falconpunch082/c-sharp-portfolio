using System;
using System.Collections.Generic;

namespace Practical_8_1
{

    public class MyStack<T>
    {
        private T[] array;
        public int Count { get; private set; }

        public MyStack(int capacity)
        {
            array = new T[capacity];
            this.Count = 0;
        }

        public void Push(T val)
        {
            if (Count < array.Length)
            {
                array[Count++] = val;
            }
            else
            {
                throw new InvalidOperationException("The stack is out of capacity.");
            }
        }

        public T Pop()
        {
            if (Count > 0)
            {
                return array[--Count];
            }
            else {
                throw new InvalidOperationException("The stack is empty.");
            }
        }

        // Method 1: Find
        public T Find(Func<T, bool> criteria)
        {
            if (criteria == null) throw new ArgumentNullException(nameof(criteria));

            for (int i = Count - 1; i >= 0; i--)
            {
                if (criteria(array[i]))
                    return array[i];
            }
            return default(T);
        }

        // Method 2: FindAll
        public T[] FindAll(Func<T, bool> criteria)
        {
            if (criteria == null) throw new ArgumentNullException(nameof(criteria));

            List<T> results = new List<T>();
            for (int i = Count - 1; i >= 0; i--)
            {
                if (criteria(array[i]))
                    results.Add(array[i]);
            }
            return results.Count > 0 ? results.ToArray() : null;
        }

        // Method 3: RemoveAll
        public int RemoveAll(Func<T, bool> criteria)
        {
            if (criteria == null) throw new ArgumentNullException(nameof(criteria));

            int removedCount = 0;
            for (int i = Count - 1; i >= 0; i--)
            {
                if (criteria(array[i]))
                {
                    // Shift elements to fill the gap
                    for (int j = i; j < Count - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    Count--;
                    removedCount++;
                }
            }
            return removedCount;
        }

        // Method 4: Max
        public T Max()
        {
            if (Count == 0) throw new InvalidOperationException("The stack is empty.");

            Comparer<T> comparer = Comparer<T>.Default;
            T maxValue = array[0];  // Initialize with the first element

            // Iterate only over the populated elements (i.e., up to Count)
            for (int i = 1; i < Count; i++)
            {
                if (comparer.Compare(array[i], maxValue) > 0) maxValue = array[i];
            }
            return maxValue;
        }

        // Method 5: Min
        public T Min()
        {
            if (Count == 0) throw new InvalidOperationException("The stack is empty.");

            Comparer<T> comparer = Comparer<T>.Default;
            T minValue = array[0];  // Initialize with the first element

            // Iterate only over the populated elements (i.e., up to Count)
            for (int i = 1; i < Count; i++)
            {
                if (comparer.Compare(array[i], minValue) < 0) minValue = array[i];
            }
            return minValue;
        }
    }

}