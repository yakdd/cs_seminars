// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Вариант без сохранения введенных чисел:
int PositiveNumbers1(int num)
{
    int count = default;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    return count;
}
Console.WriteLine();


// Вариант с сохранением введенных чисел:
int PositiveNumbers2(int num)
{
    int[] array = new int[num];
    int count = default;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    PrintArray(array);
    return count;
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



Console.Write("Сколько чисел будем вводить? ");
int m = Convert.ToInt32(Console.ReadLine());

int positiveNumbers1 = PositiveNumbers1(m);
Console.WriteLine($"Количество введенных положительных чисел -> {positiveNumbers1}.");

int positiveNumbers2 = PositiveNumbers2(m);
Console.WriteLine($"Количество введенных положительных чисел -> {positiveNumbers2}.");
