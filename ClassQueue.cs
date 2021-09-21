using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class ClassQueue<T>
    {
        private List<T> Listw = new List<T>();

        public ClassQueue()
        { 
        
        }

        public T Dequeue() // Remove and return the first value in queue
        {
            T number = Listw[0];
            Listw.RemoveAt(0);
            return number;
        }

        public void Enqueue(T value) // Add new value in queue 
        {
            Listw.Add(value);
        }
        
        public T Peek() // Return the first value in queue
        {
            return Listw[0];
        }

    }
}
