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


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//  метод создания трехмерного массива
int[,,] GetInt3dArray(int a, int b, int c)
{
    int[,,] array3D = new int[a, b, c];
    int[] temp = new int[a * b * c]; // будем проверять и заполнять 3D массив с помощью одномерного
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100); // возможно 90 уникальных значений
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j]) // проверка уникальности значений
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0; // заполнение 3D массива
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
    return array3D;
}

// метод вывода массива на печать
void Print3dArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите размер массива (X x Y x Z): ");
Console.WriteLine();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите Z: ");
int z = int.Parse(Console.ReadLine()!);

if (x * y * z > 90) Console.WriteLine("Вы ввели слишком большой массив, в этой задаче нам это не нужно");
else
{
    int[,,] array = GetInt3dArray(x, y, z);
    Print3dArray(array);
}
