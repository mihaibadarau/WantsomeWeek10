using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneric.Classes
{
    public class GenericList<T> : IEnumerable<T>
    {
        public int Capacity { get; private set; }
        public int Count { get; set; }
        private T[] array;
        private T[] auxArray;

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        public GenericList(int capacity)
        {
            Capacity = capacity;
            array = new T[capacity];
        }

        private void AutoGrow()
        {
            auxArray = new T[Capacity];
            for (int i = 0; i < Count; i++)
                auxArray[i] = array[i];

            array = new T[Capacity *= 2];
            for (int i = 0; i < auxArray.Length; i++)
                array[i] = auxArray[i];
        }

        public void Add(T value)
        {
            if (Count == Capacity - 1)
                AutoGrow();

            array[Count++] = value;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < Count - 1; i++)
                array[i] = array[i + 1];

            array[Count--] = default;
        }

        public void InsertAt(int index, T value)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();

            AutoGrow();
            for (int i = Count - 1; i >= index; i--)
                array[i + 1] = array[i];

            array[index] = value;
            Count++;
        }

        public void Clear()
        {
            array = new T[0];
            auxArray = new T[0];
            Count = 0;
            Capacity = 0;
        }

        public T Min<T>() where T : struct
        {
            dynamic min = array[0];
            for (int i = 0; i < Count; i++)
                if (array[i] < min)
                    min = array[i];

            return min;
        }

        public T Max<T>() where T : struct
        {
            dynamic max = array[0];
            for (int i = 0; i < Count; i++)
                if (array[i] > max)
                    max = array[i];

            return max;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
                yield return array[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in this)
                sb.Append($"{element}\n");

            return sb.ToString();
        }
    }
}
