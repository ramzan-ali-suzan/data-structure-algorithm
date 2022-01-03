using System.Diagnostics;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new();
            Random random = new();
            int limit = 1000000000;
            var numbers = Enumerable
            .Repeat(0, limit)
            .Select(i => random.Next(0, 100))
            .ToArray();

            sw.Start();
            GetFirstItem(numbers);
            sw.Stop();
            Console.WriteLine($"O of 1 with {numbers.Length.ToString("N0")} item: {sw.Elapsed}");

            sw.Start();
            DivideUntilZero(limit);
            sw.Stop();
            Console.WriteLine($"O of log N with number {limit}: {sw.Elapsed}");

            sw.Start();
            DivideAndConquer(limit);
            sw.Stop();
            Console.WriteLine($"O of N log N with number {limit}: {sw.Elapsed}");

            sw.Start();
            FindTheMeaningOfLife(numbers);
            sw.Stop();
            Console.WriteLine($"O of N with {numbers.Length.ToString("N0")} item: {sw.Elapsed}");

            sw.Start();
            IsSum42(numbers);
            sw.Stop();
            Console.WriteLine($"O of N^2 with {numbers.Length.ToString("N0")} item: {sw.Elapsed}");

            sw.Start();
            Fibonacci(8);
            sw.Stop();
            Console.WriteLine($"O of 2^N with number {8}: {sw.Elapsed}");

            sw.Start();
            Recursive(8);
            sw.Stop();
            Console.WriteLine($"O of N! with number {8}: {sw.Elapsed}");
        }

        // O(1)
        static int GetFirstItem(int[] array)
        {
            return array[0];
        }

        // O(log N)
        static string DivideUntilZero(double number)
        {
            if (number == 0)
            {
                return "done";
            }

            number = Math.Floor(number / 2);

            return DivideUntilZero(number);
        }

        // O(N log N)
        static string DivideAndConquer(double number)
        {
            var input = number;

            while (number > 1)
            {
                number = Math.Floor(number / 2);
                for (int i = 0; i < input; i++)
                {
                    if (i == 42)
                    {
                        return "success";
                    }
                }
            }

            return "failed";
        }

        // O(N)
        static bool FindTheMeaningOfLife(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 42)
                {
                    return true;
                }
            }

            return false;
        }

        // O(N^2)
        static bool IsSum42(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] + array[j] == 42)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // O(2^N)
        static int Fibonacci(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            if (number == 1)
            {
                return 1;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        // O(N!)
        static string Recursive(int number)
        {
            if (number == 0)
            {
                return "success";
            }

            for (int i = 0; i < number; i++)
            {
                Recursive(number - 1);
            }

            return "failed";
        }
    }
}