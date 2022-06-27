namespace _01._RecursiveArraySum
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(GetSum(numbers, 0));
        }

        private static int GetSum(int[] numbers, int index)
        {
            if (index >= numbers.Length)
            {
                return 0;
            }

            return numbers[index] + GetSum(numbers, index + 1);
        }
    }
}
