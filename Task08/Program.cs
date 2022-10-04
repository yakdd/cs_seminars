// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("Вы ввели отрицательное число!");
}
else
{
    for (int i = 1; i <= num; i++)
    {
        if ((i == num || i == num - 1) && i % 2 == 0)
        {
            Console.Write(i);
        }
        else
        {
            if (i % 2 == 0) Console.Write($"{i}, ");
        }
    }
}
