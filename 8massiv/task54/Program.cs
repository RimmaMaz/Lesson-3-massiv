// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] GetArray(int m, int n, int maxValue, int minValue)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return matrix;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Arrange(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            for(int k=j+1; k<matrix.GetLength(1); k++)
            {
                if (matrix[i, j]<matrix[i,k])
                 {
                    int temporary=matrix[i, j];
                    matrix[i, j]=matrix[i,k];
                    matrix[i, k]=temporary;
                 }
            }
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальный элемент массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальный элемент массива: ");
int minValue = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(m, n, maxValue, minValue );
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Arrange(matrix);








