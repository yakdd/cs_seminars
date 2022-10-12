// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Write("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());

// long factorial = Factorial(number);
// Console.WriteLine($"{number}! = {factorial}");
Factorial(number);



// long Factorial(long num)
void Factorial(long num)
{
    long fact = 1;
    int i;
    for (i = 1; i <= num; i++)
    {
        try
        {
            checked
            {
                fact *= i;
            }
        }
        catch (Exception)
        {
            Console.WriteLine($"После {i - 1}! наступает переполнение типа 'long'");
            break;
        }
    }
    Console.WriteLine($"{i - 1}! = {fact}");
    //     return fact;
}
