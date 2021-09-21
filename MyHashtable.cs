using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class MyHashtable<T>
    {
        private T[] Lista;

        public MyHashtable(int size)
        {
            Lista = new T[size];
        }

        public void Add(T item)
        {
            var Key = GetHash(item);
            Lista[Key] = item;
        }

        public bool Search(T item)
        {
            var Key = GetHash(item);
            return Lista[Key].Equals(item);
        }

        private int GetHash(T item)
        {
            return item.ToString().Length;
        }
    }
}

