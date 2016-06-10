using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_LIFO_FIFO
{
    class MyQueue
    {
            private int[] array = new int[5];
            private int tail = 0;

            public void Enqueue(int addValueToQueue)
            {
                if (tail < array.Length)
                {
                    array[tail] = addValueToQueue;
                    tail++;
                }
                PrintQuery();
                //Console.WriteLine("Tail is:{0}", tail);
                iSFull();
            }

            public int Dequeue()
            {
            int lastValue = array[0];
            Console.WriteLine("The last element: {0}", lastValue );
            //Console.WriteLine("Tail before delete element is:{0}", tail);
            if (tail > 0)
              {
                    array[0] = 0; //зануляем элемент
                
                 for (int i = 1; i < array.Length; i++)
                 {
                    if ((array[i] != 0) && (i < 9))
                    {
                        array[i - 1] = array[i];
                    }
                 }
                array[tail - 1] = 0;
                tail--;
             }
                else
            {
                isEmpty();
            }
             //Console.WriteLine("Tail after delete is:{0}", tail);
             PrintQuery();
             iSFull();
            //Console.WriteLine("Tail is:{0}", tail);
            return lastValue;
        }

            public void PrintQuery()
            {
                //Console.WriteLine("-----------------");
                Console.WriteLine("Queue is:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("  {0}",array[i]);
                }
            Console.WriteLine();
            }

            public void iSFull()
            {
                if (tail == array.Length)
                {
                    Console.WriteLine("Error: Query is Full!!!");
                }
                int persentQueueFull = (tail * 100) / array.Length;
                Console.WriteLine("Query is full on {0}%", persentQueueFull);
            }

            public void isEmpty()
            {
                if (tail == 0)
                {
                    Console.WriteLine("Queue is Empty");
                }
                else
                {
                    Console.WriteLine("Queue is Not empty");
                }
            }
    }
}
