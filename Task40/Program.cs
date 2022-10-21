// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите три числа. Первое: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return a + b > c && b + c > a && a + c > b;
}

bool res = Triangle(num1, num2, num3);
Console.Write(res);
