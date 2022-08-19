// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в масиве.

int[] CreateArray(int length, int min, int max)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrinArray(int[] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

bool FindNumber(int[] array, int Number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == Number) return true;
    }
    return false;
}

int[] array = CreateArray(10, 0, 101);
PrinArray(array);
Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

string Result = "отсутствует";
if (FindNumber(array, Number)) Result = "присутствует";
System.Console.WriteLine($"Число {Number} {Result} в массиве");
System.Console.WriteLine();
