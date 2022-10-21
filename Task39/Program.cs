// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}


void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}


void ReverseArrayMy(int[] array)
{
    Console.Write("[");
    for (int i = array.Length - 1; i >= 0; i--)
    {
        if (i != 0) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}


int[] arr = CreateArrayRndInt(5, 1, 9);
Console.Write("Create array:  ");
PrintArray(arr);


// VAR#1 ======================
Array.Reverse(arr);
Console.Write("Array.Reverse: ");
PrintArray(arr);


// VAR#2 ======================
ReverseArray(arr);
Console.Write("MethodReverse: ");
PrintArray(arr);


// VAR#3 ======================
Console.Write("My method arr: ");
ReverseArrayMy(arr);
