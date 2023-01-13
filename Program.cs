namespace StackQueue
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Data structure Problem");

           // PeakandPop obj = new PeakandPop();
          // CreateQueue obj = new CreateQueue(); 
            AbilityDequeue obj = new AbilityDequeue();
            Console.WriteLine("After Enqueue the elements are : ");

            obj.enqueue(70);
            obj.enqueue(30);
            obj.enqueue(56);
            Console.WriteLine("-------------------");
           
            Console.WriteLine("Elements popped from Queue = " + obj.dequeue());
            Console.WriteLine("-------------------");
            Console.WriteLine("Peek Element of the Queue is : " + obj.peek());

        }
    }
}
