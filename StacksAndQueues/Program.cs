namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stacks And Queues Program");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            Console.WriteLine("Peeking and popping from the stack until it's empty:");

            while (!stack.IsEmpty())
            {
                Console.WriteLine("Peek: " + stack.Peek());
                Console.WriteLine("Pop: " + stack.Pop());
            }

            Console.WriteLine("Stack is empty: " + stack.IsEmpty());    
        }
    }
}