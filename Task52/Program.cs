// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Задайте количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


double[] AvgColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = default;
        double avg = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        avg = sum / matrix.GetLength(0);
        array[j] = Math.Round(avg, 1);
    }
    return array;
}


void PrintArrayDbl(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.WriteLine($"{array[i]}]");
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("|");
    }
}


int[,] matrixZNumbers = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(matrixZNumbers);

double[] avg = AvgColumn(matrixZNumbers);
Console.Write(("Среднее арифметическое каждого столбца: "));
PrintArrayDbl(avg);
