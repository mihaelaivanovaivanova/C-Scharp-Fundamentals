using System;

namespace _17.SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int value = 1;
            while (row<=matrix.GetLength(0)&&matrix [row,col]==0)
            {
                matrix[row, col] = value;
                value++;
            }
            for (int i = 1; i <= matrix.GetLength(0); i++)
                for (int j = 1; j <= matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
        }
    }
}
