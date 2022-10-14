// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
    Console.Write("]");
}


bool CheckNumber(int[] arr, int findNumber)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber) return true;
    }
    return false;
}



int[] arr = CreateArrayRndInt(5, 1, 10);

Console.Write("Введите число для проверки: ");
int checkNumber = Convert.ToInt32(Console.ReadLine());

Console.Write($"{checkNumber}; ");
PrintArray(arr);

Console.WriteLine(CheckNumber(arr, checkNumber) ? " -> да" : " -> нет");
