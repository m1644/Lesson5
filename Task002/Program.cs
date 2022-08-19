// Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот.

int[] CreateArray(int length, int min, int max)  // Задать массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int[] ChangeArray(int[] array)  // Замена положительных элементов отрицательными и наоборот
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

void PrintArray(int[] array)  // Вывод
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
}

int[] array = CreateArray(4, -10, 10);
PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);
