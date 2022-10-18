// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int num, int min, int max)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}



int OddIndexSumm(int[] array)
{
    int result = default;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}



Console.Write("Введите колтичество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArr = CreateArray(number, -99, 100);
PrintArray(myArr);

int oddIndexSum = OddIndexSumm(myArr);
Console.WriteLine(oddIndexSum);
