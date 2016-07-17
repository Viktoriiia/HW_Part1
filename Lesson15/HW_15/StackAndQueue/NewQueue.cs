using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class NewQueue<T>
    {
        public NewQueue() : base()
        {

        }

        DynamicArray<T> arrayForQueue = new DynamicArray<T>();

        public void EnQueue(T valueAddToQueue)
        {
            arrayForQueue.Add(valueAddToQueue);
            arrayForQueue.Print();
        }

        public void DeQueue()
        {
            arrayForQueue.RemoveAt(0);
            arrayForQueue.Print();
        }

        public bool IsEmpty()
        {
            if (arrayForQueue.Size == 0)
            {
                return true;//Console.WriteLine("Queue is Empty!!!");
            }
            else
                return false;
        }

        public List<T> ToArray()
        {
            List<T> newQueue = new List<T>();
            for (int i = 0; i < arrayForQueue.Size; i++)
            {
                newQueue.Add(arrayForQueue.GetElementByIndex(i));
            }
            return newQueue;
        }
    }
}
