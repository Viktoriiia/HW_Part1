using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9_Dynamic
{
    public class DynamicStack<T>
    {
        public DynamicStack()
            : base()
        {

        }
        DynamicArray<T> arrayForStack = new DynamicArray<T>();

        public void Push(T valueToAdd)
        {
            arrayForStack.Add(valueToAdd);
            arrayForStack.Print();
        }

        public void Pop()
        {
            arrayForStack.RemoveAt(arrayForStack.Size - 1);
            arrayForStack.Print();
        }
        public void Peek()
        {
            arrayForStack.Get(arrayForStack.Size - 1);
            arrayForStack.Print();
        }
        public void IsEmpty()
        {
            if (arrayForStack.Size == 0)
            {
                Console.WriteLine("Stack is Empty");
            }
        }

    }

}
