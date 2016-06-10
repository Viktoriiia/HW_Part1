using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7_Sort_Queue
{

    interface IPrintable<T>
    {
        void PrintArray(T[] arrayForPrint);
    }
    interface IBuffer<T> : IPrintable<T>
    {
        void IsEmpty();
        void IsFull();
        void Peek();
    }
    interface IMyStack<T> : IBuffer<T>
    {
        void Push(T valueToPush);
        int Pop();
    }
    interface IMyQueue<T> : IBuffer<T>
    {
        void Enqueue(T addValueToQueue);
        T Dequeue();
    }

    public abstract class Buffer<T> : IBuffer<T>
    {
        protected T[] array = new T[5];
        public abstract void IsEmpty();
        public abstract void IsFull();
        public abstract void Peek();

        public void PrintArray(T[] arrayForPrint)
        {
            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                Console.WriteLine(arrayForPrint[i]);
            }
        }

    }

    public class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        private int stackPosition = 0;
        public override void IsEmpty()
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

        public override void IsFull()
        {
            if (stackPosition >= array.Length)
            {
                Console.WriteLine("Stack is Full");
            }
            float FpersentRatioFullSteck = (stackPosition * 100) / array.Length;
            Console.WriteLine("Stack is full on {0}%", FpersentRatioFullSteck);
        }

        public override void Peek()
        {
            if (stackPosition <= array.Length)
            {
                Console.WriteLine("The last element: {0}", array[stackPosition - 1]);
            }
            else
            {
                IsEmpty();
            }
        }

        public void Push(T valueToPush)
        {
            if (stackPosition < array.Length)
            {
                array[stackPosition] = valueToPush; //додаємо елемент 
                stackPosition++;
            }

            PrintArray(array);
            //Console.WriteLine("stackPosition={0}", stackPosition); 
            //Peek(); 
            IsFull();
        }

        public int Pop()
        {
            int indexForLastElement = stackPosition - 1;
            if (stackPosition > 0)
            {
                if ((stackPosition > 0) && (stackPosition <= array.Length))
                {
                    Console.WriteLine("The deleted element: {0}", array[indexForLastElement]);
                }
                //Console.WriteLine("stackPosition before delete ={0}", stackPosition);

                array[indexForLastElement] = default(T);
                //????array[indexForLastElement]=0; 

                stackPosition--;
                PrintArray(array);
                //Console.WriteLine("stackPosition after delete ={0}", stackPosition); 
                //isFull(); 
            }
            else
            {
                IsEmpty();
            }
            return indexForLastElement;
        }
    }

    public class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int tail = 0;

        public override void IsEmpty()
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

        public override void IsFull()
        {
            if (tail == array.Length)
            {
                Console.WriteLine("Error: Query is Full!!!");
            }
            int persentQueueFull = (tail * 100) / array.Length;
            Console.WriteLine("Query is full on {0}%", persentQueueFull);
        }

        public override void Peek()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(T addValueToQueue)
        {

            if (tail < array.Length)
            {
                array[tail] = addValueToQueue;
                tail++;
            }
            PrintArray(array);
            //Console.WriteLine("Tail is:{0}", tail); 
            IsFull();
        }

        public T Dequeue()
        {
            T lastValue = array[0];
            Console.WriteLine("The last element: {0}", lastValue);
            //Console.WriteLine("Tail before delete element is:{0}", tail); 
            if (tail > 0)
            {

                array[0] = default(T); //???array[0] = 0; //зануляем элемент 

                for (int i = 1; i < array.Length - 1; i++)
                {
                    //IComparable currentValue = (IComparable)array[i]; 
                    //((currentValue.CompareTo(0) > 0))//(array[i] != 0) && (i < 9)) 
                    //{ 



                    array[i - 1] = array[i];
                    //} 
                    array[tail - 1] = default(T);//array[tail - 1] = null; 
                }

                tail--;
            }
            else
            {
                IsEmpty();
            }
            //Console.WriteLine("Tail after delete is:{0}", tail); 
            PrintArray(array);
            IsFull();
            //Console.WriteLine("Tail is:{0}", tail); 
            return lastValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //int[] arrayForSort = new int[10]; 
            MyStack<int> staskInt = new MyStack<int>();
            staskInt.IsEmpty();
            Console.WriteLine("-----------------Stack---------------");
            staskInt.IsFull();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add 1 element:");
            Console.WriteLine("Add 1 element:");
            staskInt.Push(1); // додаємо 1 елемент 
            Console.WriteLine("--------------------------");
            Console.WriteLine("Check last element:");
            staskInt.Peek();// виводимо останній елемент 
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add 4 elements");
            int k = 0;
            while (k != 4) // додаемо 4-елемента до стеку 
            {
                staskInt.Push(k + 1);
                k++;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to add one more element(stack is full)");
            staskInt.Push(12); // спроба додати 6 - елемент (виходимо за рамки масиву) 
            Console.WriteLine("--------------------------");
            Console.WriteLine("Delete 4 element:");
            staskInt.Pop(); // видаляємо 4 елементів 
            staskInt.Pop();
            staskInt.Pop();
            staskInt.Pop();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Check the last element");
            staskInt.Peek();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Delete last element:");
            staskInt.Pop();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to delete one more element(Stack is empty):");
            staskInt.Pop(); // спроба видалити елемент з пустого стеку 
            Console.WriteLine();

            Console.WriteLine("-------------------MyQueue------------------");
            MyQueue<int> queueInt = new MyQueue<int>();
            queueInt.IsEmpty();
            queueInt.IsFull();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to delete element(Queue is empty):");
            queueInt.Dequeue(); // спроба видалити елемент з пустої черги 
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add 5 element to queue:");
            int h = 0;
            while (h != 5) // заповнюємо чергу 
            {
                queueInt.Enqueue(h + 1);
                h++;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to add one more element(Queue is full):");
            queueInt.Enqueue(10); // додаємо 6- елемент (черга переповнена) 
            Console.WriteLine("--------------------------");
            Console.WriteLine("Delete all elements from Queue:");
            queueInt.Dequeue(); // видаляємо всі елементи з черги 
            queueInt.Dequeue();
            queueInt.Dequeue();
            queueInt.Dequeue();
            queueInt.Dequeue();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to delete one more element(Queue is empty):");
            queueInt.Dequeue();
            Console.WriteLine("--------------------------");

            //stack.Push(12); 
            //stack.Push(4); 
            //int lastElem = stack.Pop(); 


            MyStack<string> stackString = new MyStack<string>();
            stackString.IsEmpty();
            stackString.Push("a");
            stackString.Push("s");
            stackString.Push("d");
            stackString.Push("f");
            stackString.Push("g");
            stackString.Push("h");
            stackString.Pop();
            stackString.Pop();
            stackString.Pop();
            stackString.Pop();
            stackString.Pop();
            stackString.Pop();

            MyQueue<string> queueString = new MyQueue<string>();
            queueString.IsEmpty();
            queueString.IsFull();
            queueString.Enqueue("w");
            queueString.Enqueue("a");
            queueString.Enqueue("d");
            queueString.Enqueue("z");
            queueString.Enqueue("f");
            queueString.Enqueue("h");
            queueString.Dequeue();
            queueString.Dequeue();
            queueString.Dequeue();
            queueString.Dequeue();
            queueString.Dequeue();
            queueString.Dequeue();
            Console.ReadKey();

        }
    }

}
