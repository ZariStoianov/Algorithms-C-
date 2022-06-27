namespace _05._PathsInLabyrinth
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var lab = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var colElements = Console.ReadLine();

                for (int j = 0; j < cols; j++)
                {
                    lab[i, j] = colElements[j];
                }
            }

            FindPath(lab, 0, 0, new List<string>(), string.Empty);
        }

        private static void FindPath(char[,] lab, int row, int col, List<string> directions, string direction)
        {
            //validate row, col
            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            //check for walls or already visited cells
            if (lab[row, col] == '*' || lab[row, col] == 'v')
            {
                return;
            }

            directions.Add(direction);
            //check for end
            if (lab[row, col] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            lab[row, col] = 'v';

            FindPath(lab, row - 1, col, directions, "U");// up
            FindPath(lab, row + 1, col, directions, "D");// down
            FindPath(lab, row, col - 1, directions, "L");// left
            FindPath(lab, row, col + 1, directions, "R");// right

            lab[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}
