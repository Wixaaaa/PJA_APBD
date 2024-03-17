namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
