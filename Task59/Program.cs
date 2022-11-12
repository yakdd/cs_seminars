
// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


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


int[] FindFirstMinElementIndex(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexI = default;
    int indexJ = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexI = i;
                indexJ = j;
            }
        }
    }
    int[] minIndex = { indexI, indexJ };
    return minIndex;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
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


int[,] ReduceMatrix(int[,] matrix, int[] array)
{
    int[,] reduceMatrixRow = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)];
    // удаляем строку:
    for (int i = 0; i < reduceMatrixRow.GetLength(0); i++)
    {
        for (int j = 0; j < reduceMatrixRow.GetLength(1); j++)
        {
            if (i >= array[0])
            {
                reduceMatrixRow[i, j] = matrix[i + 1, j];
            }
            else
            {
                reduceMatrixRow[i, j] = matrix[i, j];
            }
        }
    }

    // удаляем столбец:
    int[,] reduceMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < reduceMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < reduceMatrix.GetLength(1); j++)
        {
            if (j >= array[1])
            {
                reduceMatrix[i, j] = reduceMatrixRow[i, j + 1];
            }
            else
            {
                reduceMatrix[i, j] = reduceMatrixRow[i, j];
            }
        }
    }
    return reduceMatrix;
}



int[,] matrixZnumbers = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(matrixZnumbers);

int[] minElementIndex = FindFirstMinElementIndex(matrixZnumbers);
PrintArray(minElementIndex);

Console.WriteLine();

int[,] reduceMatr = ReduceMatrix(matrixZnumbers, minElementIndex);
PrintMatrix(reduceMatr);
