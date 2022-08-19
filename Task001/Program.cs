// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray(int length, int min, int max)  // Задать массив рандом!!!
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)  // Вывод (печать) массива!!!
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array [i]} ");
    Console.WriteLine();
}

int FindPositiveSum(int[] arr)  // Сумма положительных элементов в массиве!!!
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        sum += arr[i];
    }
    return sum;
}

int FindNegativeSum(int[] arr)  // Сумма отрицательных элементов в массиве!!!
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        sum += arr[i];
    }
    return sum;
}

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
Console.WriteLine($"Сумма положительных элементов равна {FindPositiveSum(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна {FindNegativeSum(array)}");
