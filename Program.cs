using System;
using System.Text;

public class Class1
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть к-сть рядків матриці:");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введіть к-сть стовпців матриці:");
        int col = int.Parse(Console.ReadLine());
        Console.Write("A = ");
        int A = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, col];
        matrix = EnteringMatrix(row, col, matrix);
        Solution(matrix, A, row, col);
    }
    static int[,] EnteringMatrix(int row, int col, int[,] matrix)
    {
        Console.WriteLine("Введіть елементи масива порядково через пробіл");
        for (int i = 0; i < row; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = int.Parse(s[j]);
            }
        }
        return matrix;
    }
    static void Solution(int[,] matrix, int A, int row, int col)
    {
        int counter = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (matrix[i, j] > A)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine($"Кількість елементів які перевищують А = {counter}");
    }
}

