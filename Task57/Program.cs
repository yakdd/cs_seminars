// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.



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


int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("|");
    }
}


void PrintFrequency(int[] array)
{
    Console.WriteLine("Частота появления элементов в матрице:");
    int count = 1;
    int elem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == elem) count++;
        else
        {
            Console.WriteLine($"{elem,2} => {count}");
            count = 1;
            elem = array[i];
        }
    }
    Console.WriteLine($"{elem,2} => {count}");
}



int[,] myMatrix = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(myMatrix);
int[] array = MatrixToArray(myMatrix);

Array.Sort(array);
PrintFrequency(array);
