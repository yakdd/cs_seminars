// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int num, int min, int max)
{
    double[] array = new double[num];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);
    }
    return array;
}



double FindMax(double[] array)
{
    double maxElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxElem) maxElem = array[i];
    }
    return maxElem;
}



double FindMin(double[] array)
{
    double minElem = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minElem) minElem = array[i];
    }
    return minElem;
}



void PrintArrayDbl(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}



double[] myArr = CreateArrayRndDouble(10, 0, 99);
PrintArrayDbl(myArr);

double findMax = FindMax(myArr);
double findMin = FindMin(myArr);

Console.WriteLine($"Разница между максимальным ({findMax}) и минимальным ({findMin}) элементами массива = {findMax - findMin}");
