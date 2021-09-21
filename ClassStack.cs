using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class ClassStack<T>
    {
        private List<T> Listw = new List<T>();
        
        public void Push(T obj) // Add value in stack 
        {
            Listw.Insert(0, obj);
        }
        
        public T Pop() // Remove and return the first value
        {
            T number = Listw[0];
            Listw.RemoveAt(0);
            return number;
        }

        public T Peek() // Return the first value in stack
        {
            return Listw[0];
        }
    }
}
