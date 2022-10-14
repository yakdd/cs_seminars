// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void CreateArray(int count)
{
    int[] arr = new int[count];
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.Write($"{arr[i]}]");
        else Console.Write($"{arr[i]}, ");
    }
}

CreateArray(8);
