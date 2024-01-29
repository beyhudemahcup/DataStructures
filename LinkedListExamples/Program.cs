namespace LinkedListExamples
{

    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            numbers.AddFirst(5);//make it first element of the linkedList

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            LinkedListNode<int> currentNode = numbers.First;//for iteration
            
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);//print all the elements one by one
                currentNode = currentNode.Next;

                numbers.AddFirst(11);
            }
        }
    }
}