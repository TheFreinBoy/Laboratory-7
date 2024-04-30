using System;
using System.Text;
using System.Linq;

public class Class4
{
    static void Main() //Упорядкувати рядки матриці за зменшенням елементів 2-ої (технічно 2-ої, яку на побутовому рівні назвали б третьою) колонки.
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть к-сть рядків матриці:");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введіть к-сть стовпців матриці:");
        int col = int.Parse(Console.ReadLine());
        int[][] matrix = new int[row][];
        matrix = EnteringMatrix(row, col, matrix);
        int[][] sortedMatrix = Solution(matrix);
        PrintMatrix(sortedMatrix);
    } 
    static int[][] EnteringMatrix(int row, int col, int[][] matrix)
    {
        Console.WriteLine("Введіть елементи масива порядково через пробіл");
        for (int i = 0; i < row; i++)
        {
            matrix[i] = new int[col];           
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < col; j++)
            {
                matrix[i][j] = int.Parse(s[j]);
            }
        }
        return matrix;
    }
    static int[][] Solution(int[][] matrix)
    {
        int[][] sortedMatrix = matrix.OrderBy(row => row[1]).ToArray();
        Array.Reverse(sortedMatrix);
        return sortedMatrix;
    }
    static void PrintMatrix( int[][] matrix)
    {
        Console.WriteLine(" ");
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
