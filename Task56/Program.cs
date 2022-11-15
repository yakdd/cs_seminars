// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


int[] CountSumRows(int[,] matrix)
{
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summ = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summ += matrix[i, j];
        }
        sumRows[i] = summ;
    }
    return sumRows;
}


int FindMinElement(int[] array)
{
    int minElement = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
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



int[,] matrixZnumbers = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrixZnumbers);

int[] countSumRows = CountSumRows(matrixZnumbers);
int findMinElement = FindMinElement(countSumRows);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {findMinElement} строка.");
