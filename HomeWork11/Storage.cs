using System;


namespace Task11
{
    public class Storage <T>
    {
        private List<T> lst;

        public Storage()
        {
            lst = new List<T>();
        }

        public void PrintAll()
        {
            for(int i  = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
        }

        public void Add(T item)
        {
            lst.Add(item);
        }

        public void Delete(T item)
        {
            lst.Remove(item);
        }

        public void Update(T item, T newItem)
        {
            int index = lst.IndexOf(item);
            if(index != -1)
            {
                lst[index] = newItem;
            }
            else
            {
                Console.WriteLine(item +" can't be found in the list");
            }
        }

        private int findIndex(T item)
        {
            return lst.IndexOf(item);
        }

    }
}

