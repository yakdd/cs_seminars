// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] SetOfEquations(double a, double b, double c, double d)
{
    double[] coords = new double[2];
    coords[0] = Math.Round(((d - b) / (a - c)), 3);
    coords[1] = Math.Round((a * coords[0] + b), 3);
    return coords;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


Console.Write("Введите первый коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первую константу b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второй коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второую константу b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] result = SetOfEquations(a: k1, b: b1, c: k2, d: b2);
Console.Write($"Координаты точки пересечения прямых -> ");
PrintArray(result);
