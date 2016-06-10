using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> intArray = new DynamicArray<int>();
            DynamicStack<int> stack = new DynamicStack<int>();
            Console.WriteLine("-----------------DynamicIntStack--------------------");
            stack.IsEmpty();
            for (int i = 1; i < 25; i++)
            {
                stack.Push(i);
            }
            int y = 0;
            while (y < 25)
            {
                stack.Pop();
                y++;
            }

            Console.WriteLine();

            DynamicStack<string> stringStack = new DynamicStack<string>();
            Console.WriteLine("-----------------DynamicSTRINGStack--------------------");
            stringStack.IsEmpty();
            stringStack.Push("K");
            stringStack.Push("E");
            stringStack.Push("E");
            stringStack.Push("P");
            stringStack.Push("");
            stringStack.Push("C");
            stringStack.Push("A");
            stringStack.Push("L");
            stringStack.Push("M");
            stringStack.Push("");
            stringStack.Push("and");
            stringStack.Push("Drink");
            stringStack.Push("TEA");
            stringStack.Push("!");

            for (int i =0; i<15; i++)
            {
                stringStack.Pop();
            }
            Console.WriteLine();




            Console.WriteLine("-----------------DynamicQuery--------------------");
            DynamicQueue<int> query = new DynamicQueue<int>();
            query.IsEmpty();
            for (int i = 1; i < 20; i++)
            {
                query.EnQueue(i);
            }

            int k = 0;
            while (k < 20)
            {
                query.DeQueue();
                k++;
            }

            Console.WriteLine();

            Console.WriteLine("-----------------DynamicQuery--------------------");
            DynamicQueue<string> stringQuery = new DynamicQueue<string>();
            query.IsEmpty();
            stringQuery.EnQueue("K");
            stringQuery.EnQueue("E");
            stringQuery.EnQueue("E");
            stringQuery.EnQueue("P");
            stringQuery.EnQueue("");
            stringQuery.EnQueue("C");
            stringQuery.EnQueue("A");
            stringQuery.EnQueue("L");
            stringQuery.EnQueue("M");
            stringQuery.EnQueue("");
            stringQuery.EnQueue("and");
            stringQuery.EnQueue("DREAM !!!");


            int t = 0;
            while (t < 15)
            {
                stringQuery.DeQueue();
                t++;
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
