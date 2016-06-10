using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Sort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayInt = new int[10];
            Random ran = new Random();
            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = ran.Next(100);
                Console.Write("  {0}", arrayInt[i]);
            }
            Console.WriteLine();

            BubbleSort((int[])arrayInt.Clone());
            InsertionSort((int[])arrayInt.Clone());

            Console.ReadKey();
        }

        static int [] Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  {0}", array[i]);
            }
            Console.WriteLine();
        }

        static void BubbleSort(int[] arrayInt)
        {
            Console.WriteLine("---------------------------Bubble Sort------------------------------");

            for (int i = 0; i < arrayInt.Length - 1; i++)
            {
                for (int j = 0; j < arrayInt.Length - i - 1; j++)
                {
                    if (arrayInt[j] > arrayInt[j + 1])
                    {
                        PrintArray(arrayInt);
                        Swap(arrayInt, j + 1, j);
                    }
                }
            }
            PrintArray(arrayInt);
        }

        static void InsertionSort(int[] arrayInt)
        {
            Console.WriteLine("------------------Insertion Sort---------------------------------");

            for (int i = 1; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < arrayInt[i - 1])
                {
                    PrintArray(arrayInt);
                    Swap(arrayInt, i - 1, i);

                    for (int j = i - 1; j > 0; j--)
                    {
                        if (arrayInt[j] < arrayInt[j - 1])
                        {
                            PrintArray(arrayInt);
                            Swap(arrayInt, j, j - 1);
                        }
                    }
                }
            }
            PrintArray(arrayInt);
        }


    }
}
