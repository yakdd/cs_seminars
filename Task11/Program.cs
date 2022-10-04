﻿// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int NumDivision(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {number}");

int newNumber = NumDivision(number);
Console.WriteLine($"Новое число => {newNumber}");
