// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координаты точки");
Console.Write("Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0 ? $"{quarter}" : "Incorrect coords";
Console.WriteLine(result);

int Quarter(int x_coord, int y_coord)
{
    if (x_coord > 0 && y_coord > 0) return 1;
    if (x_coord < 0 && y_coord > 0) return 2;
    if (x_coord < 0 && y_coord < 0) return 3;
    if (x_coord > 0 && y_coord < 0) return 4;
    return 0;
}