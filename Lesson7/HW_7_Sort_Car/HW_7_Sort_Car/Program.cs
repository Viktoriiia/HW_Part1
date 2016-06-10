using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7_Sort_Car
{
    interface IPrintable<T>
    {
        void Print(T[] arrayToPrint);
    }

    interface ISorter<T> : IPrintable<T>
    {
        T [] Sort(T[] arrayToSort);
    }


    public abstract class Sorter<T> : ISorter<T>
    {
        public abstract T[] Sort(T[] arrayToSort);

        public void Print(T[] arrayToPrint)
        {
            Console.WriteLine("---------------------------------------");
            for (int i=0; i<arrayToPrint.Length; i++)
            {
                Console.Write("  {0}",arrayToPrint[i]);
            }
            Console.WriteLine();
        }

        protected T[] Swap(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            return array;
        }
    }

    public class BubbleSorter<T> : Sorter<T>
    {
        public override T[] Sort(T[] array)
        {
            Console.WriteLine("---------------------------Bubble Sort------------------------------");
            if (!(array[0] is IComparable))
            {
                Console.WriteLine("Error");
                return array;
            }
            else
            {

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        IComparable ICurrentIndex = (IComparable)array[j];
                        IComparable INextIndex = (IComparable)array[j + 1];

                        if (ICurrentIndex.CompareTo(INextIndex) > 0)     //   array[j] > array[j + 1])
                        {
                            Print(array);
                            Swap(array, j + 1, j);
                        }
                    }
                }
                Print(array);
                return array;
            }
        }
    }

    public class InsertionSort<T> : Sorter<T>
    {
        public override T[] Sort(T[] array)
        {
            Console.WriteLine("------------------Insertion Sort---------------------------------");

            if (!(array[0] is IComparable))
            {
                Console.WriteLine("Error");
                return array;
            }
            else
                {
                for (int i = 1; i < array.Length; i++)
                {
                    IComparable ICurrentIndex = (IComparable)array[i];
                    IComparable INextIndex = (IComparable)array[i - 1];
                    if (ICurrentIndex.CompareTo(INextIndex) < 0)//(array[i] < array[i - 1])
                    {
                        Print(array);
                        Swap(array, i - 1, i);

                        for (int j = i - 1; j > 0; j--)
                        {
                            IComparable IFirstIndex = (IComparable)array[j];
                            IComparable ISecondIndext = (IComparable)array[j - 1];
                            if (IFirstIndex.CompareTo(ISecondIndext) < 0)//(array[j] < array[j - 1])
                            {
                                Print(array);
                                Swap(array, j, j - 1);
                            }
                        }
                    }
                }
                Print(array);

                return array;
            }
        }
    }
    //public class CarSorter<T> : Sorter<T>
    //{
    //    //private void Swap(T[] array, int index1, int index2)
    //    //{
    //    //    Print(array[index1], array[index2]);
    //    //    T temp = array[index1];
    //    //    array[index1] = array[index2];
    //    //    array[index2] = temp;
    //    //}

    //    public override T[] Sort(T[] array)
    //     {

    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            IComparable one = (IComparable)array[i];
    //            IComparable two = (IComparable)array[i - 1];
    //            if (one.CompareTo(two) == -1)
    //            {
    //                //PrintArray(array);
    //                Swap(array, i - 1, i);
                    

    //                for (int j = i - 1; j > 0; j--)
    //                {
    //                    IComparable three = (IComparable)array[i - 2];
    //                    //if ( (array[j] as IComparable)     (array[j - 1] as IComparable) )
    //                    if (two.CompareTo(three) == -1)
    //                    {
    //                        //PrintArray(array);
    //                        Swap(array, j, j - 1);
    //                    }
    //                }
    //            }

    //        }


        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine((array[i] as ICar).YearOfProduction);
        //    }

        //}
//}


        class Program
    {
        static void Main(string[] args)
        {

            int[] arrayForSort = new int[] { 7,5,4,6,3};

            BubbleSorter<int> intBubbleSort = new BubbleSorter<int>();
            //intBubbleSort.Sort(arrayForSort);
            intBubbleSort.Print(intBubbleSort.Sort(arrayForSort));

            int[] arrayForSort2 = new int[] { 9, 8, 5, 4, 3 };
            InsertionSort<int> intInsertionSort = new InsertionSort<int>();
            intInsertionSort.Print(intInsertionSort.Sort(arrayForSort2));

            string[] arrayStr1 = new string[] { "w", "a", "s"};
            BubbleSorter<string> strBubbleSort = new BubbleSorter<string>();
            strBubbleSort.Print(strBubbleSort.Sort(arrayStr1));

            string[] arrayStr2 = new string[] { "w", "d", "s", "g", "z", "y", "b"};
            InsertionSort<string> strInsertionSort = new InsertionSort<string>();
            strInsertionSort.Print(strInsertionSort.Sort(arrayStr2));

            Car car1 = new Car("Opel", 1998, "red");
            Car car2 = new Car("Honda", 2005, "wite");
            //Car car3 = new Car("Mazda", 1995, "wite");
            //Car car4 = new Car("BMW", 2003, "wite");
            //Car car5 = new Car("Mersedes", 2000, "wite");
            //Car car6 = new Car("Honda", 2010, "wite");
            //Car car7 = new Car("Kia", 1999, "wite");

            //Console.WriteLine(car11.CompareTo(car21));

            Car[] arrayOfCars = new Car[7];
            arrayOfCars[0] = car1;//new Car("Opel", 1998, "red");
            arrayOfCars[1] = car2;//new Car("Honda", 2005, "wite");
            arrayOfCars[2] = new Car("Mazda", 1995, "wite");
            arrayOfCars[3] = new Car("BMW", 2003, "wite");
            arrayOfCars[4] = new Car("Mersedes", 2000, "wite");
            arrayOfCars[5] = new Car("Honda", 2010, "wite");
            arrayOfCars[6] = new Car("Kia", 1999, "wite");

            BubbleSorter<Car> carSorter = new BubbleSorter<Car>();
            carSorter.Print(carSorter.Sort(arrayOfCars));

            Console.WriteLine();

            Console.ReadKey();

        }
    }

}

