// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubeTable(int num)
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}:");
    Console.WriteLine("+--------+--------+");

    for (int index = 1; index <= num; index++)
    {
        Console.WriteLine($"|{index,7} |{Math.Pow(index, 3),7} |");
    }

    Console.WriteLine("+--------+--------+");
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);
