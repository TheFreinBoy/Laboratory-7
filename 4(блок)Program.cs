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
        int[][] sortedMatrix = Solution(matrix,1);
        PrintMatrix(sortedMatrix);
    } 
    static int[][] EnteringMatrix(int row, int col, int[][] matrix)
    {       
        int[][] array_of_arrays = new int[row][];
        for (int i = 0; i < array_of_arrays.Length; i++)
        {
            Console.WriteLine("Введіть рядок через пробіл");
            string[] input = Console.ReadLine().Split(' ');
            array_of_arrays[i] = new int[input.Length];
            for (int j = 0; j < input.Length; j++)
            {
                array_of_arrays[i][j] = int.Parse(input[j]);
            }
        }
        return array_of_arrays;
    }
    static int[][] Solution(int[][] matrix, int columnIndex)
    {
        int rowCount = matrix.Length;
        bool swapped = true; 
        while (swapped)
        {
            swapped = false; 
            for (int i = 0; i < rowCount - 1; i++)
            {
                if (matrix[i][columnIndex] < matrix[i + 1][columnIndex])
                {                   
                    int[] temp = matrix[i];
                    matrix[i] = matrix[i + 1];
                    matrix[i + 1] = temp;
                    swapped = true; 
                }
            }
        }
       return matrix;
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
