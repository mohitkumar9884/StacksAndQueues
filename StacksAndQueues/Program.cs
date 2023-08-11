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

            Console.WriteLine("Top element of the stack: " + stack.Peek());   

            Console.WriteLine("Popped: " + stack.Pop());  
            Console.WriteLine("Popped: " + stack.Pop());  
            Console.WriteLine("Popped: " + stack.Pop());  
            Console.WriteLine("Is the stack empty? " + stack.IsEmpty());  
        }
    }
}