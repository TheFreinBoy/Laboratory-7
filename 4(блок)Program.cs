using System;
using System.Text;

public class Class4
{
    static void Main() //Упорядкувати рядки матриці за зменшенням елементів 2-ої (технічно 2-ої, яку на побутовому рівні назвали б третьою) колонки.
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть к-сть рядків матриці:");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введіть к-сть стовпців матриці:");
        int col = int.Parse(Console.ReadLine());              
        int[,] matrix = new int[row, col];
        matrix = EnteringMatrix(row, col, matrix); 
        Solution(matrix, row, col);     
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
    static void Solution(int[,] matrix, int row, int col )
    {                   
        int column = 2;
        for (int i = 0; i < row - 1; i++)
        {
            for (int j = 0; j < row - i - 1; j++)
            {
                if (matrix[j, column] < matrix[j + 1, column])
                {                   
                    for (int k = 0; k < col; k++)
                    {
                        int temp = matrix[j, k];
                        matrix[j, k] = matrix[j + 1, k];
                        matrix[j + 1, k] = temp;
                    }
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


