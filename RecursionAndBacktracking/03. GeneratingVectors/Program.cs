namespace _03._GeneratingVectors
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var arr = new int[number];

            PrintVectors(arr, 0);
        }

        private static void PrintVectors(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join("", arr));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    PrintVectors(arr, index + 1);
                }
            }
        }
    }
}
