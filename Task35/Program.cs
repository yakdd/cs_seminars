// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}



int FindElements(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100) count++;
    }
    return count;
}


int[] arr = CreateArrayRndInt(20, 1, 1000);
PrintArray(arr);

int elements = FindElements(arr);
Console.WriteLine($"Количество двухзначных элементов в массиве = {elements}");
