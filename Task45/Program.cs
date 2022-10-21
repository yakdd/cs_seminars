
// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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


int[] CopyArray(int[] array)
{
    int[] newArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArr[i] = array[i];
    }
    return newArr;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] fibonacci = Fibonacci(number);
PrintArray(fibonacci);
int[] myArr = CopyArray(fibonacci);
PrintArray(myArr);
