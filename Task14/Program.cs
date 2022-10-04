// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// Var.1 ===========================
// bool CheckingNumber1(int number, int div1, int div2)
// {
//     return number % div1 == 0 && number % div2 == 0;
// }

// bool result = CheckingNumber1(num, 7, 23);
// if (result)
// {
//     Console.Write("да");
// }
// else { Console.Write("нет"); }

// Var.2 ===========================
bool CheckingNumber2(int number, int divisor)
{
    return number % divisor == 0;
}

if (CheckingNumber2(num, 7) && CheckingNumber2(num, 23)) Console.Write("да");
else Console.Write("нет");
