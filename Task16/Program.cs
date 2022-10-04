// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool CheckingNumbers(int a, int b)
{
    return a * a == b || b * b == a;
}

bool result = CheckingNumbers(num1, num2);
if (result) Console.Write("да");
else Console.Write("нет");
