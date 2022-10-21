// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string DecToBin(int num)
{
    string result = String.Empty;
    while (num > 0)
    {
        result = Convert.ToString(num % 2) + result;
        num /= 2;
    }
    return result;
}



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number);
Console.WriteLine(decToBin);
