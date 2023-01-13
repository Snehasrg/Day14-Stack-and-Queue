namespace StackQueue
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Data structure Problem");

           // PeakandPop obj = new PeakandPop();
           CreateQueue obj = new CreateQueue(); 
            Console.WriteLine("After push the elements are : ");

            obj.enqueue(70);
            obj.enqueue(30);
            obj.enqueue(56);
            Console.WriteLine("-------------------");
           
           // Console.WriteLine("Item popped from stack = " + obj.pop());
            Console.WriteLine("Peek Element of the stack is : " + obj.peek());

        }
    }
}
