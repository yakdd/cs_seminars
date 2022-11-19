// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Akerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akerman(m - 1, Akerman(m, n - 1));
    else return n + 1;
}


int akerman1 = Akerman(2, 3);
Console.WriteLine(akerman1);
int akerman2 = Akerman(3, 2);
Console.WriteLine(akerman2);