// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A:");
Console.Write(" координата Х: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write(" координата Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write(" координата Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write(" координата Х: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write(" координата Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write(" координата Z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Distance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    int xDelta = xB - xA;
    int yDelta = yB - yA;
    int zDelta = zB - zA;

    double result = Math.Sqrt(xDelta * xDelta + yDelta * yDelta + zDelta * zDelta);
    return Math.Round(result, 2, MidpointRounding.ToZero);
}

double dist = Distance(xA, yA, zA, xB, yB, zB);
Console.Write($"Расстояние между точками A и B в трехмерном пространстве равно {dist}");
