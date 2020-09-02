using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EToolService.Desktop.Models
{
    /// <summary>
    /// Similar to KeyValuePair but implemented for counting elements
    /// </summary>
    public class Pair<T>
    {
        private T element { get; set; }
        private int elementCount { get; set; }
        public T Value
        {
            get { return element; }
            set { element = value; }
        }
        public int Count
        {
            get { return elementCount; }
            set { elementCount = value; }
        }
    }

    /// <summary>
    /// If you are using an custom object for Repetitor, you should
    /// implement your own Equals() method.
    /// </summary>
    public class RecycleCollection<T> : ICollection<T>, IEnumerable
    {
        private Pair<T>[] PairArray;
        private int Count;
        public RecycleCollection()
        {
            Count = 0;
            PairArray = new Pair<T>[Count];
        }
        public bool IsReadOnly => false;
        int ICollection<T>.Count => Count;
        public void Add(T item)
        {
            int exist = Exists(item);
            if (exist != -1)
            {
                PairArray[exist].Count++;
                return;
            }

            Pair<T>[] temp = new Pair<T>[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                temp[i] = new Pair<T>();
                temp[i].Value = PairArray[i].Value;
                temp[i].Count = PairArray[i].Count;
            }
            temp[Count] = new Pair<T>();
            temp[Count].Value = item;
            temp[Count].Count = 1;

            Count++;
            PairArray = temp;
        }
        public int Exists(T item)
        {
            for (int i = 0; i < Count; i++)
                if (PairArray[i].Value.Equals(item))
                    return i;
            return -1;
        }
        public void Clear()
        {
            Count = 0;
            PairArray = new Pair<T>[Count];
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
                if (PairArray[i].Value.Equals(item))
                    return true;

            return false;
        }
        public void CopyTo(T[] arr, int arrayIndex)
        {
            if (arr == null)
                throw new ArgumentNullException();

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException();

            if (arrayIndex >= Count)
                throw new ArgumentOutOfRangeException();

            for (int i = 0; i < arr.Count(); i++)
                Add(arr[i]);
        }
        public RepetitorEnum<T> GetEnumerator()
        {
            return new RepetitorEnum<T>(PairArray);
        }
        public bool Remove(T item)
        {
            int exist = Exists(item);
            if (exist == -1)
                return false;

            Pair<T>[] temp = new Pair<T>[Count - 1];

            int k = 0;

            for (int i = 0; i < Count; i++)
            {
                if (i == exist)
                    continue;
                else
                {
                    temp[k].Value = PairArray[k].Value;
                    temp[k].Count = PairArray[k].Count;
                    k++;
                }
            }

            PairArray = temp;
            Count--;

            return true;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Returns a Repetitor collection based on passed list argument.
        /// If you are using an custom object for Repetitor, you should
        /// implement your own Equals() method.
        /// </summary>
        public static RecycleCollection<T> FromCollection(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException();

            RecycleCollection<T> rep = new RecycleCollection<T>();
            foreach (var item in collection)
            {
                rep.Add(item);
            }
            return rep;
        }
    }

    public class RepetitorEnum<T> : IEnumerator
    {
        public Pair<T>[] _elements;

        int position = -1;
        bool disposed = false;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public RepetitorEnum(Pair<T>[] list)
        {
            _elements = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _elements.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {
            Dispose(true);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
            }

            disposed = true;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Pair<T> Current
        {
            get
            {
                try
                {
                    return _elements[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}