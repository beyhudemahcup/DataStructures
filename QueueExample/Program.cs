
namespace QueueExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Queue<int> queue = new Queue<int>();

            ////adding a new item
            //queue.Enqueue(1);
            //Console.WriteLine($"The first item of the queue is: {queue.Peek()}");

            //queue.Enqueue(2);
            //queue.Enqueue(3);

            ////removing an item
            //queue.Dequeue();//deletes number 3
            //Console.WriteLine($"The front item of the queue is: {queue.Peek()}");

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine($"The front value ({queue.Dequeue()}) is removed from the queue");
            //    Console.WriteLine($"Current queue count is : {queue.Dequeue()}");
            //}
            
            Queue<Order> orders = new Queue<Order>();

            foreach (Order order in RecieveOrdersFromAmazon())
            {
                orders.Enqueue(order);
            }

            foreach (Order order in RecieveOrdersFromAlibaba())
            {
                orders.Enqueue(order);
            }

            while (orders.Count > 0)
            {
                Order currentOrder = orders.Dequeue();
                currentOrder.ProcessOrder();
            }

        }
        static Order[] RecieveOrdersFromAmazon()
        {
            Order[] orders = new Order[]{
                new Order(1,3),
                new Order(2,43),
                new Order(3,76),
                new Order(4,12),
                };

            return orders;
        }

        static Order[] RecieveOrdersFromAlibaba()
        {
            Order[] orders = new Order[]{
                new Order(5,95),
                new Order(6,14),
                new Order(7,10),
                };

            return orders;
        }
    }
}