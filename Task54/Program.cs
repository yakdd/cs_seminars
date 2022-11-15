// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] CreateMatrixRndInt(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) { matrix[i, j] = rnd.Next(min, max + 1); }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) { Console.Write($"{matrix[i, j],3} "); }
        Console.WriteLine("|");
    }
}


int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
    return array;
}


void SortMatrixRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] row = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        int[] rowSorted = SortArray(row);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rowSorted[j];
        }
    }
}



int[,] matrixZnumbers = CreateMatrixRndInt(5, 3, 1, 10);
Console.WriteLine("Исходная матрица случайных чисел:");
PrintMatrix(matrixZnumbers);
SortMatrixRows(matrixZnumbers);

Console.WriteLine("\nМатрица со строками, отсортированными по убыванию:");
PrintMatrix(matrixZnumbers);
