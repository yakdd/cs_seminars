// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.Write("Задайте количесто строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количесто столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] CreateMatrixRndDouble(int rows, int cols, int min, int max)
{
    double[,] matrix = new double[rows, cols];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rndNum = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(rndNum, 1);
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}  ");
        }
        Console.WriteLine("|");
    }
}



double[,] matrixRNumbers = CreateMatrixRndDouble(m, n, -10, 10);
PrintMatrix(matrixRNumbers);
