namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stacks And Queues Program");
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            Console.WriteLine("Dequeuing from the beginning:");

            while (!queue.IsEmpty())
            {
                int dequeued = queue.Dequeue();
                Console.WriteLine("Dequeued: " + dequeued);
            }

            Console.WriteLine("Is the queue empty? " + queue.IsEmpty());

        }
    }
}