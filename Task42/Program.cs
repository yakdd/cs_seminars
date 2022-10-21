// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string DecToBin(int num)
{   // перевод десятичного числа в двоичный код
    string result = String.Empty;
    while (num > 0)
    {
        result = Convert.ToString(num % 2) + result;
        num /= 2;
    }
    return result;
}


int Binary(int num)
{   // перевод десятичного числа в двоичный код
    int result = 0;
    int count = 1;
    while (num > 0)
    {
        result = (num % 2) * count + result;
        num /= 2;
        count *= 10;
    }
    return result;
}



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number);
Console.WriteLine(decToBin);

int binary = Binary(number);
Console.WriteLine(binary);
