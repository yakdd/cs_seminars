// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int[] MultiplePars(int[] array)
{
    int newArrLength = array.Length / 2;
    if (array.Length % 2 == 1) newArrLength += 1;

    int[] newArray = new int[newArrLength];

    for (int i = 0; i < newArrLength; i++)
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 == 1)
    {
        // newArray[newArrLength - 1] = array[newArrLength - 1];
        newArray[newArrLength - 1] = array[array.Length / 2];
    }
    return newArray;
}


int[] arrEven = CreateArrayRndInt(4, 1, 10);
int[] newArr1 = MultiplePars(arrEven);

int[] arrOdd = CreateArrayRndInt(5, 1, 10);
int[] newArr2 = MultiplePars(arrOdd);

PrintArray(arrEven);
PrintArray(newArr1);

PrintArray(arrOdd);
PrintArray(newArr2);
