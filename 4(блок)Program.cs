using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введіть кількість рядків у матриці:");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців у матриці:");
        int col = int.Parse(Console.ReadLine());
        int[,] matrix = new int[row, col];              
        EnteringMatrix(matrix);                     
        SortRowsByColumn(matrix, 1); 
        Console.WriteLine(" ");
        PrintMatrix(matrix);
    }
    static int[,] EnteringMatrix(int[,] matrix)
    {    
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);
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
    static void SortRowsByColumn(int[,] matrix, int columnIndex)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);      
        int[] rowIndex = new int[rowCount]; //Індекс рядків
        for (int i = 0; i < rowCount; i++)
        {
            rowIndex[i] = i;
        }    
          
        for (int i = 1; i < rowCount; i++) //Cортування вставками
        {
            int key = rowIndex[i];
            int j = i - 1;
            for (; j >= 0 && matrix[rowIndex[j], columnIndex] < matrix[key, columnIndex]; j--)
            {
                rowIndex[j + 1] = rowIndex[j];
            }
            rowIndex[j + 1] = key;
        }  

        int[,] sortedMatrix = new int[rowCount, colCount];
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                sortedMatrix[i, j] = matrix[rowIndex[i], j];
            }
        } 
                     
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                matrix[i, j] = sortedMatrix[i, j];
            }
        }        
    }
    static void PrintMatrix(int[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
