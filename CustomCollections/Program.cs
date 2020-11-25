using System;
using System.Collections.Generic;

namespace CustomCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            
            MyList<string> myCities = new MyList<string>();
            myCities.Add("Ankara");
            myCities.Add("İstanbul");
            



            foreach (var item in myCities.Items)
            {
                Console.WriteLine(item);
            }

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length+1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }

            _array[_array.Length - 1] = item;
        }

        public void Remove(T item)
        {

        }

        public T[] Items { get { return _array; } }

    }
}
