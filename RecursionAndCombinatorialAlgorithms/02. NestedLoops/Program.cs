namespace _02._NestedLoops
{
    using System;

    public class Program
    {

        private static int[] elements;
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            elements = new int[num];
            NestedLoops(0);
        }

        private static void NestedLoops(int index)
        {
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            for (int i = 1; i <= elements.Length; i++)
            {
                elements[index] = i;
                NestedLoops(index + 1);
            }
        }
    }
}
