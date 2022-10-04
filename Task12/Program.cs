// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string CheckingNumbers(int number1, int number2)
{
    if (number1 % number2 == 0)
        return "кратно";
    else
        return $"не кратно, остаток {number1 % number2}";

}

string result = CheckingNumbers(num1, num2);
Console.Write(result);
