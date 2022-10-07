// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.Write("Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());


double Distanse(int x1, int y1, int x2, int y2)
{
    int xDelta = x2 - x1;
    int yDelta = y2 - y1;

    double result = Math.Round(Math.Sqrt(Math.Pow(xDelta, 2) + Math.Pow(yDelta, 2)), 2, MidpointRounding.ToZero);
    return result;
}

double distanse = Distanse(x1, y1, x2, y2);
Console.Write($"Расстояние между точками равно {distanse}");
