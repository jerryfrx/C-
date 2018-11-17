using System;
using System.Collections;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1,2,3,4,5};
            ArrayList nums2 = new ArrayList{ 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Sum(nums2));
            Console.WriteLine("==============================");
            var roc = new ReadOnlyCollection(nums1);
            foreach (var item in roc)
            {
                Console.WriteLine(item);
            }
        }
        static int Sum(ICollection num)
        {
            int sum = 0;
            foreach (var item in num)
            {
                sum += (int)item;
            }
            return sum;
        }
    }
    class ReadOnlyCollection : IEnumerable
    {
        private int[] _array;
        public ReadOnlyCollection(int[] array)
        {
            _array = array;
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection)
            {
                _collection = collection;
                _head = -1;
            }
            public object Current
            {
                get
                {
                    object o = _collection._array[_head];
                    return o;
                }
            }
            public bool MoveNext()
            {
                if (++_head < _collection._array.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Reset()
            {
               _head = -1;
            }
        }
    }
}
