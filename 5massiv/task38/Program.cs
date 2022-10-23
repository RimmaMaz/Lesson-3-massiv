// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int counteven (int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

Console.WriteLine("ВВедите длину массива");

int a = int.Parse(Console.ReadLine()!);

int[] array = GetArray(a);

counteven(array);

Console.WriteLine(string.Join(",", array));

Console.Write($"Колличество четных чисел равно {counteven(array)}");













