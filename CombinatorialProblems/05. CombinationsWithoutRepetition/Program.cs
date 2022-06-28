namespace _05._CombinationsWithoutRepetition
{
    using System;

    public class Program
    {
        private static string[] elements;
        private static string[] combinations;
        private static int k;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            GenCombination(0, 0);
        }

        private static void GenCombination(int index, int elementsStartInd)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = elementsStartInd; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                GenCombination(index + 1, i + 1);
            }
        }
    }
}
