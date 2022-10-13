// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
double basis = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
double degree = Convert.ToDouble(Console.ReadLine());



double result = Degree(basis, degree);
Console.WriteLine("=======================================");
Console.WriteLine($"Число {basis} в степени {degree} = {result}");


double NaturalDegree(double bas, double deg)
{
    double result = 1;
    for (int i = 1; i <= deg; i++)
    {
        result *= bas;
    }
    return result;
}



double Degree(double bas, double deg)
{
    if (bas == 0) return 0;

    double result = 1;

    // =================================================
    if ((deg % 2 != 0) && (deg % 2 != 1))   // проверка числа на дробность
    {
        result = 1000000.0;
        return result;
    }
    // =================================================

    else
    {
        if (deg == 0) return result;

        else if (deg > 0)
        {
            result = NaturalDegree(bas, deg);
        }
        else if (deg < 0)
        {
            deg *= -1;
            result = 1 / NaturalDegree(bas, deg);
        }
        else { Console.WriteLine("Число В должно быть целым числом!"); }
    }

    return result;
}
