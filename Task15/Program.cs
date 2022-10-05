// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool CheckDayoff(int day)
{
    return day == 6 || day == 7;
}

Console.Write("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber > 0 && dayNumber < 8)
{
    bool answer = CheckDayoff(dayNumber);
    if (answer) Console.Write("Да (выходной)");
    else Console.Write("Нет (не выходной)");
}
else Console.Write("Нет такого дня недели!");