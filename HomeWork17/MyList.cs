using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork17
{
    public class MyList<T> : IEnumerable<T>
    {

        //public T[] Items { get; set; }
        private T[] _items;
        public MyList()
        {
            _items = new T[0];
        }

        public T[] GetArray()
        {
            return _items;
        }



        public void Add(T item)
        {
            try
            {
                Array.Resize(ref _items, _items.Length + 1);
                _items[_items.Length - 1] = item;
            }
            catch
            {
                throw new CustomException("Invalid argument in Add method");
            }
            
        }

        public void AddRange(int index, T[] items)
        {
            try
            {
                Array.Resize(ref _items, (int)items.Length + _items.Length);

                T[] arr = new T[items.Length];
                for (int i = 0; i < items.Length; i++)
                {
                    arr[i] = index + i < _items.Length ? _items[index + i] : default(T);
                    _items[i + index] = items[i];
                }
                for (int i = items.Length + index, j = 0; i < _items.Length; i++, j++)
                {
                    _items[i] = arr[j];
                }
            }
            catch
            {
                throw new CustomException("Invalid arguments in AddRange() method");
            }
            
        }


        public void Remove(T element)
        {
            try
            {
                T[] arr = new T[0];
                int index = Array.IndexOf(_items, element);

                for (int i = 0; i < _items.Length; i++)
                {

                    if (index == i)
                    {
                        continue;
                    }
                    else
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = _items[i];
                    }
                }
                _items = arr.Length == _items.Length ? _items : arr;
            }
            catch
            {
                throw new CustomException("Invalid Element");
            }
        }

        public void RemoveRange(int index, int numOfElements)
        {
            if(index >  _items.Length || index < 0)
            {
                throw new CustomException("Index is out of array bouns");
            }
            if(numOfElements < 0 || numOfElements > _items.Length - index)
            {
                throw new CustomException("Invalid Number of elements");
            }

            T[] arr = new T[0];

            for (int i = 0, j = 0; i < _items.Length; i ++){
                if(i >= index && j < numOfElements)
                {
                    j++;
                    continue;
                }
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = _items[i];

            }
            _items = arr.Length == _items.Length ? _items : arr;

        }

        public void RemoveAt (int index)
        {
            if(index > _items.Length - 1)
            {
                throw new CustomException("Index out of array bounds");
            }
            T[] arr = new T[0];

            for (int i = 0; i < _items.Length; i++)
            {

                if (index == i)
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = _items[i];
                }
            }
            _items = arr.Length == _items.Length ? _items : arr;
        }


        public T Indexer(int index)
        {
            for(int i = 0; i< _items.Length; i++)
            {
                if(index == i)
                {
                    return _items[i];
                }
            }
            throw new CustomException("index is out of array range");
        }

        public int Count()
        {
            return (int)_items.Length;
        }


        public bool Contains(T element)
        {
            try
            {
                foreach (T item in _items)
                {
                    if (item.Equals(element))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                throw new CustomException("Invalid element");
            }
            
        }
        public T Single(Func<T, bool> condition)
        {
            int occurs = 0;
            T ans = default(T);
            foreach (T element in _items)
            {
                if (condition(element))
                {
                    occurs++;
                    ans = element;
                }
                if(occurs > 1)
                {
                    throw new CustomException("Array contains more then one elemen which satisfies the condition");
                }
            }
            if(occurs == 0)
            {
                throw new CustomException("No matching element in the array");
            }
            return ans;

        }

        public T SingleOrDefault(Func<T, bool> condition)
        {
            int occurs = 0;
            T ans = default(T);
            foreach (T element in _items)
            {
                if (condition(element))
                {
                    occurs++;
                    ans = element;
                }
                if (occurs > 1)
                {
                    throw new CustomException("Array contains more then one elemen which satisfies the condition");
                }
            }
            return ans;
        }


        public T Find(Predicate<T> predicate)
        {
            try
            {
                foreach (T item in _items)
                {
                    if (predicate(item))
                    {
                        return item;
                    }
                }
                return default(T);
            }
            catch
            {
                throw new CustomException("Invalid predicate function");
            }
        }

        public T[] Where (Func<T, bool> condition)
        {
            try
            {
                T[] ans = new T[0];
                foreach (T item in _items)
                {
                    if (condition(item))
                    {
                        Array.Resize(ref ans, ans.Length + 1);
                        ans[ans.Length - 1] = item;
                    }
                }
                return ans;
            }
            catch
            {
                throw new CustomException("invalid condition");
            }
            
        }








        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0 ; i< _items.Length; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
