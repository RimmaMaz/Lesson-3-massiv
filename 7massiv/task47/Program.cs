//Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числами.


double[,] GetArray(int m, int n, double maxValue, double minValue)
{
    double[,] matrix = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t ");
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
double maxValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальный элемент массива: ");
double minValue = int.Parse(Console.ReadLine()!);
double[,] matrix = GetArray(m, n, maxValue, minValue );
PrintArray(matrix);





