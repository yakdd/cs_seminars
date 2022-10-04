// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона [10, 99] => {number}");

int maxDigit = MaxDigit(number);

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit; // тернарный оператор
    return result;
}

Console.WriteLine($"Максимальная цифра в числе => {maxDigit}");