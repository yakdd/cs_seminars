// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SummOfSeries(int num1, int num2)
{
    int sum = num1;
    if (num1 == num2) return sum;
    sum += SummOfSeries(num1 + 1, num2);
    return sum;
}


int sumMN = default;
while (true)
{
    Console.Write("Введите первое число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m > n)
    {
        sumMN = SummOfSeries(n, m);
        break;
    }
    else if (m < n)
    {
        sumMN = SummOfSeries(m, n);
        break;
    }
    else Console.WriteLine("Числа должны быть разными.");
}

Console.WriteLine(sumMN);
