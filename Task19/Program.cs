// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool palindrom = Palindrom5digit(number);
    if (palindrom) Console.WriteLine("Да, это палиндром.");
    else Console.WriteLine("Нет, это не палиндром.");
}
else
{
    bool palindrom = PalindromUniversal(number);
    if (palindrom) Console.WriteLine("Это не пятизначное число, но это палиндром.");
    else Console.WriteLine("Это не пятизначное число и это не палиндром.");
}



bool Palindrom5digit(int num)
{
    int intDivisor = 10000;

    while (number >= 100)
    {
        int firstDigit = number / intDivisor;
        int lastDigit = number % 10;
        if (firstDigit != lastDigit) return false;
        number = number / 10 % 1000;
        intDivisor /= 100;
    }
    return true;
}



bool PalindromUniversal(int num)
{
    int initialNum = num;
    int reverseNum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        reverseNum = (reverseNum + lastDigit) * 10;
        num /= 10;
    }
    reverseNum /= 10;

    if (reverseNum == initialNum) return true;
    else return false;
}
