// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    if (num < 0) num *= -1;
    while (num > 1000) num /= 10;
    return num % 10;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 || number < -99)
{
    int thirdDigit = ThirdDigit(number);
    Console.Write($"Третья цифра числа => {thirdDigit}");
}
else Console.Write("У этого числа нет третьей цифры.");
