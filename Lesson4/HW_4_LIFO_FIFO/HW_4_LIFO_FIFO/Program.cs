using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_LIFO_FIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();
            Console.WriteLine("-----------------Stack---------------");
            stack.isEmpty();
            stack.isFull();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add 1 element:");
            //Console.WriteLine("Add 1 element:");
            stack.Push(1);  // додаємо 1 елемент
            Console.WriteLine("--------------------------");
            Console.WriteLine("Check last element:");
            stack.Peek();   // виводимо останній елемент
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add 4 elements");
            int k = 0;
            while (k != 4)      // додаемо 4-елемента до стеку
            {
                stack.Push(k + 1);
                k++;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to add one more element(stack is full)");
            stack.Push(12);  // спроба додати 6 - елемент (виходимо за рамки масиву)
            Console.WriteLine("--------------------------");
            Console.WriteLine("Delete 4 element:");
            stack.Pop();    // видаляємо 4 елементів
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Check the last element");
            stack.Peek();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Delete last element:");
            stack.Pop();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to delete one more element(Stack is empty):");
            stack.Pop();     // спроба видалити елемент з пустого стеку
            Console.WriteLine();
            Console.WriteLine("-------------------MyQueue------------------");
            MyQueue queue = new MyQueue();
            queue.isEmpty();
            queue.iSFull();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to delete element(Queue is empty):");
            queue.Dequeue();   // спроба видалити елемент з пустої черги
            Console.WriteLine("--------------------------");
            Console.WriteLine("Add 5 element to queue:");
            int h = 0;
            while (h != 5)      // заповнюємо чергу
            {
                queue.Enqueue(h + 1);
                h++;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to add one more element(Queue is full):");
            queue.Enqueue(10);  // додаємо 6- елемент (черга переповнена)
            Console.WriteLine("--------------------------");
            Console.WriteLine("Delete all elements from Queue:");
            queue.Dequeue();    // видаляємо всі елементи з черги
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Try to delete one more element(Queue is empty):");
            queue.Dequeue();
            Console.WriteLine("--------------------------");

            stack.Push(12);
            stack.Push(4);
            int lastElem = stack.Pop();
            Console.ReadKey();
        }
    }
  


}
