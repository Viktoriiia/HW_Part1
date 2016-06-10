using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_LIFO_FIFO
{
    public class Buffer
    {
        protected int[] array = new int[5];

        public Buffer()
        {
        
        }
        public virtual void isFull()
        {
            Console.WriteLine("isFull");
        }
        public virtual void isEmpty()
        {
            Console.WriteLine("isEmpty");
        }
        public void PrintBuffer()
        {
            Console.WriteLine("-------------------------");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  {0}", array[i]);
            }
            Console.WriteLine();
        }
    }




    }
