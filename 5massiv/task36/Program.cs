// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Getarray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);

    }
    return array;
}

    int unevenSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }


Console.WriteLine("Введите длину массива ");
int a = int.Parse(Console.ReadLine()!);

int[] array = Getarray(a, -10, 10);

unevenSum(array);

Console.WriteLine($"Сумма нечетных чисел равна {unevenSum(array)}");

Console.WriteLine(string.Join(" ", array));







