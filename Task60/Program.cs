// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

bool CheckUniqueNumber(int number, int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number) return true;
            }
        }
    }
    return false;
}


int[,,] CreateCubeMatrixRndInt(int row, int cols, int depth, int min, int max)
{
    int[,,] matrix3D = new int[row, cols, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                int newNumber = default;
                while (true)
                {
                    newNumber = rnd.Next(min, max);
                    if (!CheckUniqueNumber(newNumber, matrix3D)) break;
                }
                matrix3D[i, j, k] = newNumber;
            }
        }
    }
    return matrix3D;
}



void PrintCubeMatrix(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}



int[,,] createCubeMatrixRndInt = CreateCubeMatrixRndInt(2, 2, 2, 10, 100);
PrintCubeMatrix(createCubeMatrixRndInt);
