using System;
using System.Text;

public class Class2
{
    //Обміняти місцями елементи головної і побічної діагоналей; вважати, що матриця гарантовано квадратна.
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть к-сть рядків матриці:");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введіть к-сть стовпців матриці:");
        int col = int.Parse(Console.ReadLine());              
        int[,] matrix = new int[row, col];
        matrix = EnteringMatrix(row, col, matrix); 
        Solution(matrix, row);     
        PrintMatrix(matrix, row, col);  
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
    static void Solution(int[,] matrix, int row)
    {     
        for (int i = 0; i < row; i++)
        {
            int temp = matrix[i, i];
            matrix[i, i] = matrix[i, row - 1 - i];
            matrix[i, row - 1 - i] = temp;
        }
    }
    static void PrintMatrix(int [,] matrix, int row, int col)
    {      
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}  

