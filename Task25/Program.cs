// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
double basis = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите целое число B: ");
double degree = Convert.ToDouble(Console.ReadLine());


if ((Math.Abs(degree) % 2 != 0) && (Math.Abs(degree) % 2 != 1))   // проверка числа на дробность
{
    Console.WriteLine("Показатель степени должен быть целым числом!");
}
else
{
    double wholeDegree = WholeDegree(basis, degree);
    Console.WriteLine($"Число {basis} в степени {degree} = {wholeDegree}");
}



double WholeDegree(double bas, double deg)
{
    double result = 1;

    if (bas == 0) return 0;
    else
    {
        if (deg == 0) return result;

        else if (deg > 0)
        {
            result = NaturalDegree(bas, deg);
        }
        else if (deg < 0)
        {
            result = 1 / NaturalDegree(bas, Math.Abs(deg));
        }
    }

    return result;
}



double NaturalDegree(double bas, double deg)
{
    double result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result *= bas;
    }
    return result;
}
