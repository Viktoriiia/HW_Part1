using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 0;
            Console.WriteLine("Enter the size of the array");
            bool enterArraySize = int.TryParse(Console.ReadLine(), out arrayLength);
            if (enterArraySize == false)
                {
                    Console.WriteLine("Error: Need enter only digits.");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            
            //arrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Array size: {0}", arrayLength);
            int[] arrayEntered = new int[arrayLength];

            Console.WriteLine("Enter array");

            for (int i=0; i<arrayLength; i++)
            {
                Console.WriteLine("Enter {0} -element of the array",i);
                //arrayEntered[i] = int.Parse(Console.ReadLine());
                bool ArrayEntered = int.TryParse(Console.ReadLine(), out arrayEntered[i]);
                if(ArrayEntered == false)
                {
                    Console.WriteLine("Error: you entered word, not digits");
                    Console.ReadKey();
                    Environment.Exit(1);
                }
            }
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Array {0}: {1}", i, arrayEntered[i]);
            }

            int min = arrayEntered[0];
            int max = arrayEntered[0];
            for (int i=0; i<arrayLength; i++)
            {
                if(arrayEntered[i]>max)
                {
                    max = arrayEntered[i];
                }
                if(arrayEntered[i]<min)
                {
                    min = arrayEntered[i];
                }
            }
            Console.WriteLine("max:{0}", max);
            Console.WriteLine("min:{0}", min);
            Console.ReadKey();
        }
    }
}
