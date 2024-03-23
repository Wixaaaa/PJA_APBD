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

            int[] numbers = { 1, 2, 3, 4, 5 };
            double average = CalculateAverage(numbers);
            Console.WriteLine("Średnia wynosi: " + average);

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);

        }

        static double CalculateAverage(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
            }

            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }

            return (double)sum / array.Length;
        }

        static int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
