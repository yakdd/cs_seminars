// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) { Console.Write($"{matrix[i, j],3}"); }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void SpiralMatrix(int[,] matrix, int num, int row, int col)
{
    int maxIndex = matrix.GetLength(1) - 1;

    if (matrix[row, col] == 0)
    {
        matrix[row, col] = num + 1;
        num = matrix[row, col];

        if (col < maxIndex && row <= col + 1) SpiralMatrix(matrix, num, row, col + 1);
        if (row < maxIndex && row < col) SpiralMatrix(matrix, num, row + 1, col);
        if (col > 0) SpiralMatrix(matrix, num, row, col - 1);
        if (row >= 0 && col < row) SpiralMatrix(matrix, num, row - 1, col);
    }
}



Console.Write("Введите размерность квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] spiralMatrix = new int[size, size];
SpiralMatrix(spiralMatrix, 0, 0, 0);
PrintMatrix(spiralMatrix);
