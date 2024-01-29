
using System.Collections.Generic;

namespace StackExamples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //data can be added/removed from top
            //cant access easily middle data
            //LIFO (last in first out)
            Stack<int> stack = new Stack<int>();

            //add an element
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //get the last added element (3 is the data in this example)
            //Console.WriteLine($"The last element of the Stack is: {stack.Peek()}");

            //removing the data we should use Pop method, it also return the removed value 
            stack.Pop();
            Console.WriteLine($"The element is popped: {stack.Pop()}");
            Console.WriteLine($"The last element of the Stack is: {stack.Peek()}");

            //lets order this array to show LIFO type
            int[] arr = new int[] {1,2,3,4,5,6,7,8,9,10 };

            Stack<int> orderArray = new Stack<int>();

            Console.Write("array:\n" + string.Join(" ,", arr) + "\n");

            foreach (int i in arr)
            {
                orderArray.Push(i);
            }

            Console.WriteLine("array after pushing the Stack");

            while (orderArray.Count > 0)
            {
                Console.Write(orderArray.Pop() + ", ");
            }
            //this proves that the Stack has LIFO type!
          
        }
    }
}