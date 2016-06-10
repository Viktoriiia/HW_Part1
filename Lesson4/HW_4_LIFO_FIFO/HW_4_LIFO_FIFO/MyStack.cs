using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_LIFO_FIFO
{
    class MyStack
    {
        private int[] array = new int[5];
        private int stackPosition = 0;

        public void Push(int valueToPush)
        {
            if (stackPosition < array.Length)
            {
                array[stackPosition] = valueToPush; //додаємо елемент
                stackPosition++;
            }
             
            PrintStack();
            //Console.WriteLine("stackPosition={0}", stackPosition);
            //Peek();
            isFull();
        }

        public int Pop( )
        {
            int lastElement = stackPosition - 1;
            if (stackPosition > 0)
            {
                if ((stackPosition > 0) && (stackPosition <= array.Length))
                {
                    Console.WriteLine("The deleted element: {0}", array[lastElement]);
                }
                //Console.WriteLine("stackPosition before delete ={0}", stackPosition);
                array[stackPosition - 1] = 0;
                stackPosition--;             
                PrintStack();
                //Console.WriteLine("stackPosition after delete ={0}", stackPosition);
                isFull();
            }
            else
            {
                isEmpty();
            }
            return lastElement;
        }

        public void isEmpty()
        {
            if (stackPosition == 0)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Stack is not empty");
            }
        }

        public void isFull()
        {
            if (stackPosition >= array.Length)
            {
                Console.WriteLine("Stack is Full");
            }
            float FpersentRatioFullSteck = (stackPosition * 100) / array.Length;
            Console.WriteLine("Stack is full on {0}%", FpersentRatioFullSteck);
        }

        public void PrintStack()
        {
            //Console.WriteLine("-------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  {0}",array[i]);
            }
            Console.WriteLine();
        }

        public void Peek( )
        {
            //int lastPosition = stackPosition - 1;
            if (stackPosition <= array.Length)
            {
                Console.WriteLine("The last element: {0}", array[stackPosition-1]);
            }
            else
            {
                isEmpty();
            }
            //return lastPosition;
        }
}
}
