// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10. 99].

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array [i]} ");
    Console.WriteLine();
}

int FindElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
int[] array = CreateArray(123, 0, 123);
PrintArray(array);
Console.Write("Количество элементов массива, значения которых лежат в отрезке [10. 99] равно - ");
int count = FindElement(array);
Console.Write(count);
