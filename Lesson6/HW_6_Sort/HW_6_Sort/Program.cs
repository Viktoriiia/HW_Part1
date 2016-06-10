using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6_Sort
{

    public class Sort
    {

        public int[] Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }

        public void PrintArray(int[] array)
        {
            Console.WriteLine("Array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("  {0}", array[i]);
            }
            Console.WriteLine();
        }
       
        public virtual void SortArray(int [] arrayForSort)
        {
            Console.WriteLine("Sort111");
        }

    }

    public class BubbleSort:Sort
    {
        public override void SortArray(int [] arrayForSort)
        {
            Console.WriteLine("---------------------------Bubble Sort------------------------------");

            for (int i = 0; i < arrayForSort.Length - 1; i++)
            {
                for (int j = 0; j < arrayForSort.Length - i - 1; j++)
                {
                    if (arrayForSort[j] > arrayForSort[j + 1])
                    {
                        PrintArray(arrayForSort);
                        Swap(arrayForSort, j + 1, j);
                    }
                }
            }
            PrintArray(arrayForSort);
        }
    }

    public class InsertionSort: Sort
    {
        public override void SortArray(int[] arrayForSort)
        {
            Console.WriteLine("------------------Insertion Sort---------------------------------");

            for (int i = 1; i < arrayForSort.Length; i++)
            {
                if (arrayForSort[i] < arrayForSort[i - 1])
                {
                    PrintArray(arrayForSort);
                    Swap(arrayForSort, i - 1, i);

                    for (int j = i - 1; j > 0; j--)
                    {
                        if (arrayForSort[j] < arrayForSort[j - 1])
                        {
                            PrintArray(arrayForSort);
                            Swap(arrayForSort, j, j - 1);
                        }
                    }
                }
            }
            PrintArray(arrayForSort);
        }
    }

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


            Sort bubbleSortMethod = new BubbleSort();
            bubbleSortMethod.SortArray((int[])arrayInt.Clone());

            Sort insertionSortMethod = new InsertionSort();
            insertionSortMethod.SortArray((int [])arrayInt.Clone());
            Console.ReadKey();

        }
    }
}
