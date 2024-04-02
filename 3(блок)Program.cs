using System;
using System.Text;

public class Class3
{
    /* Упорядкувати за незростанням головну діагональ матриці (тобто, максимальний
     ліворуч-угорі, мінімальний праворуч-унизу); вважати, що матриця гарантовано
     квадратна.*/
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
        for (int i = 0; i < row - 1; i++)
        {
            for (int j = i + 1; j < row; j++)
            {
                if (matrix[i, i] < matrix[j, j])
                {
                    int temp = matrix[i, i];
                    matrix[i, i] = matrix[j, j];
                    matrix[j, j] = temp;
                }
            }
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

