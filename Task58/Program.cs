// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int[,] matrixCultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    // Индексы, используемые для определения размерности матриц: matrixA [m, n]; matrixB [n, k]
    for (int m = 0; m < matrixC.GetLength(0); m++)
    {
        for (int k = 0; k < matrixC.GetLength(1); k++)
        {
            int element = default;
            for (int n = 0; n < matrixA.GetLength(1); n++)
            {
                element += matrixA[m, n] * matrixB[n, k];
            }
            matrixC[m, k] = element;
        }
    }
    return matrixC;
}



int[,] matrixA = CreateMatrixRndInt(4, 2, 0, 10);
Console.WriteLine("Матрица А:");
PrintMatrix(matrixA);

int[,] matrixB = CreateMatrixRndInt(2, 3, 0, 10);
Console.WriteLine("\nМатрица B:");
PrintMatrix(matrixB);


if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int[,] matrixC = matrixCultiplication(matrixA, matrixB);
    Console.WriteLine("\nМатрица C (= A x B):");
    PrintMatrix(matrixC);
}
else Console.WriteLine("\nМатрицы перемножить нельзя.");
