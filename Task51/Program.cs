// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
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


// int SumElements(int[,] matrix)
// {
//     int sum = default;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j) sum += matrix[i, j];
//         }
//     }
//     return sum;
// }


int SumElements2(int[,] matrix)
{
    int sum = default;
    int demention = (matrix.GetLength(0) > matrix.GetLength(1)) ? 1 : 0;
    for (int i = 0; i < matrix.GetLength(demention); i++) sum += matrix[i, i];
    return sum;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}


int[,] array2D = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2D);

int sumElements = SumElements2(array2D);
Console.WriteLine(sumElements);
