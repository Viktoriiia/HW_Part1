using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Dynamic
{
    public class DynamicQueue<T>
    {
        public DynamicQueue() : base()
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

        public void IsEmpty()
        {
            if (arrayForQueue.Size == 0)
            {
                Console.WriteLine("Queue is Empty!!!");
            }
        }

    }

}
