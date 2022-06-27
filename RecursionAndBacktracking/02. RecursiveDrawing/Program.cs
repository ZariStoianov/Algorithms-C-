namespace _02._RecursiveDrawing
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            DrawFigure(number);
        }

        private static void DrawFigure(int number)
        {
            if (number == 0)
            {
                return;
            }

            Console.WriteLine(new String('*', number));

            DrawFigure(number - 1);

            Console.WriteLine(new String('#', number));
        }
    }
}
