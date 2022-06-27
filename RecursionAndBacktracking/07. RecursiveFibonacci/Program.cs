namespace _07._RecursiveFibonacci
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            CalcFibonacci(number);

            Console.WriteLine(CalcFibonacci(number));
        }

        private static int CalcFibonacci(int number)
        {
            if (number <= 1 || number >= 45)
            {
                return 1;
            }

            return CalcFibonacci(number - 1) + CalcFibonacci(number - 2);
        }
    }
}
