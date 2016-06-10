using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_LIFO_FIFO
{
    public class MyStack : Buffer
    {
        private int stackPosition = 0;

        public void Push(int valueToPush)
        {
            if (stackPosition < array.Length)
            {
                array[stackPosition] = valueToPush; //додаємо елемент
                stackPosition++;
            }

            PrintBuffer();
            //Console.WriteLine("stackPosition={0}", stackPosition);
            //Peek();
            isFull();
        }

        public int Pop()
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
                PrintBuffer();
                //Console.WriteLine("stackPosition after delete ={0}", stackPosition);
                isFull();
            }
            else
            {
                isEmpty();
            }
            return lastElement;
        }

        public override void isEmpty()
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

        public override void isFull()
        {
            if (stackPosition >= array.Length)
            {
                Console.WriteLine("Stack is Full");
            }
            float FpersentRatioFullSteck = (stackPosition * 100) / array.Length;
            Console.WriteLine("Stack is full on {0}%", FpersentRatioFullSteck);
        }

        public void Peek()
        {
            //int lastPosition = stackPosition - 1;
            if (stackPosition <= array.Length)
            {
                Console.WriteLine("The last element: {0}", array[stackPosition - 1]);
            }
            else
            {
                isEmpty();
            }

        }

    }
}
