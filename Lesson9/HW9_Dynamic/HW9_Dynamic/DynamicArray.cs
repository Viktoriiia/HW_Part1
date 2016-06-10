using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Dynamic
{
    public class DynamicArray<T>
    {
        private T[] array;
        private int mySize = 0;
        private int myCapacity = 0;

        public int Size
        {
            get
            {
                return mySize;
            }
            set
            {
                mySize = value;
            }
        }
        public int Capacity
        {
            get
            {
                return myCapacity;
            }
            set
            {
                myCapacity = value;
            }
        }
        public DynamicArray()
        {
            Size = 0;
            Capacity = Size + 5;
            array = new T[Capacity];
        }
        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i] + " ");
            }
        }

        private void Resize()
        {
            T[] arrayT = new T[array.Length + 5];
            for (int i = 0; i < array.Length; i++)
            {
                arrayT[i] = array[i];
            }
            array = arrayT;
        }


        public void Add(T valueToAdd)
        {
            Console.WriteLine();
            if (Size == Capacity)
            {
                Resize();
                Capacity = array.Length;
            }
            array[Size] = valueToAdd;
            Size++;
            Console.WriteLine();

        }

        public void Insert(T valueToInsert, int indexToInsert)
        {
            if ((Size > 0) && (indexToInsert < Size))
            {
                if (Size == Capacity)
                {
                    Resize();
                    Capacity = array.Length;
                }
                for (int i = Size - 1; i >= indexToInsert; i--)
                {
                    array[i + 1] = array[i];
                }
                array[indexToInsert] = valueToInsert;
                Size++;
            }
            else if (indexToInsert > Size)
            {
                Console.WriteLine("\n Error: the last value is:{0}", Size);
            }
        }

        public void Get(int indexToPrint)
        {
            if (indexToPrint < Size)
            {
                Console.WriteLine("\n Value is {0}", array[indexToPrint]);
            }
            else
            {
                Console.WriteLine("\n The last value is {0}!!!", Size);
            }
        }

        public void RemoveAt(int indexForValueToRemove)
        {
            Console.WriteLine();
            if ((Size > 0) && (indexForValueToRemove < Size))
            {
                array[indexForValueToRemove] = default(T);
                for (int i = indexForValueToRemove; i < Size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[Size - 1] = default(T);
                Size--;
            }
            else
            {
                Console.WriteLine("\n the are no value to delete!!! The last value is :{0}", Size);
            }
            Console.WriteLine();
        }
    }

}
