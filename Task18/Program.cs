// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти координатной плоскости: ");
string num = Console.ReadLine();

string result = Range(num);
Console.WriteLine(result);

string Range(string number)
{
    if (number == "1") return "x > 0 и y > 0";
    if (number == "2") return "x < 0 и y > 0";
    if (number == "3") return "x < 0 и y < 0";
    if (number == "4") return "x > 0 и y < 0";
    return "Ошибка ввода.";
}
