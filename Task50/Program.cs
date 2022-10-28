// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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


int[,] matrixZNumbers = CreateMatrixRndInt(m, n, -10, 10);
PrintMatrix(matrixZNumbers);



Console.Write("Введите номер строки нужного элемента: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца нужного элемента: ");
int col = Convert.ToInt32(Console.ReadLine()) - 1;


bool CheckData(int[,] matrix, int row, int col)
{
    return row < matrix.GetLength(0) && col < matrix.GetLength(1);
}


bool checking = CheckData(matrixZNumbers, row, col);
if (checking) Console.WriteLine($"На указанной позиции находится элемент со значением {matrixZNumbers[row, col]}");
else Console.WriteLine("Такого элемента в массиве нет.");
