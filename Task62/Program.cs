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
        for (int j = 0; j < matrix.GetLength(1); j++) { Console.Write($"{matrix[i, j],3} "); }
        Console.WriteLine();
    }
}


void SpiralMatrix(int[,] matrix, int num, int row, int col)
{
    // PrintMatrix(matrix);
    // Console.WriteLine("-----------------");


    if (matrix[row, col] == 0)
    {
        matrix[row, col] = num + 1;
        num = matrix[row, col];

        if (col == matrix.GetLength(1) - 1) return;
        SpiralMatrix(matrix, num, row, col + 1);

        if (row == matrix.GetLength(0) - 1) return;
        SpiralMatrix(matrix, num, row + 1, col);

        if (col == 0) return;
        SpiralMatrix(matrix, num, row, col - 1);

        if (row == 0) return;
        SpiralMatrix(matrix, num, row - 1, col);
    }
}

int size = 4;
int[,] spiralMatrix = new int[size, size];
SpiralMatrix(spiralMatrix, 0, 0, 0);
Console.WriteLine("=================");
PrintMatrix(spiralMatrix);
