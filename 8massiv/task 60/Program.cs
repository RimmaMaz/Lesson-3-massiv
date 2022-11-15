// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] Get3DArray(int m, int n, int l,  int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0;  k< n; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue+1);
            }
        }
    }
    return result;
}

void Print3DArray(int[,,] inArray)
{
     for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0;  k< inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}");
                Console.Write($"({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[] BinArrayInToSingle(int[,,] array)
{
    int[] ChengedArray= new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
    int n=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0;  k< array.GetLength(2); k++)
            {
                ChengedArray[n++]=array[i, j, k];
            }
        }
    }
    return ChengedArray;
}


bool СorrectArray(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        for(int j=i+1; i<array.Length; i++)
        if(array[i]==array[j])
        {
            return true;
        }
    }
    return false;
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество страниц массива: ");
int pages = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,,] userArray=Get3DArray(row, colums, pages, 10, 100);
int[] arrayForCheck = BinArrayInToSingle(userArray);

if(СorrectArray(arrayForCheck))
{
    Print3DArray(userArray);
    Console.WriteLine();
    Console.Write("Элементы массива неуникальны. Запустить код заново");
}
else
{
    Console.WriteLine();
    Print3DArray(userArray);
    Console.WriteLine();
}
