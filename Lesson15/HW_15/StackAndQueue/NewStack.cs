using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
   public class NewStack<T>
    {
        public NewStack()
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
        public bool IsEmpty()
        {
            if (arrayForStack.Size == 0)
            {
                return true;//Console.WriteLine("Stack is Empty");
            }
            else return false;
        }
        public List<T> ToArray()
        {
            List<T> newStack = new List<T>();
            for (int i = 0; i < arrayForStack.Size; i++)
            {
                newStack.Add(arrayForStack.GetElementByIndex(i));
            }
            return newStack;
        }
    }
}
