// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int num)
{
    if (num < 0) num *= -1;
    return num % 100 / 10;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number < 1000 && number > 99) || (number > -1000 && number < -99))
{
    int secondDigit = SecondDigit(number);
    Console.Write($"Вторая цифра числа => {secondDigit}");
}
else Console.Write("Это не трехзначное число.");
