//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] NewArray (int size, int minval, int maxval)
{
    double[] array=new double[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(minval, maxval);
    }
    return array;
}

double Max(double[] array)
{
    double max = array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>max)
        {
            max=array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]<min)
        {
            min=array[i];
        }
    }
    return min;
}

Console.WriteLine("Введите длину массива ");
int a= int.Parse(Console.ReadLine()!);

double[] array=NewArray(a, 1, 100);
Console.WriteLine(string.Join(" ", array));

double min = Min(array);
double max = Max(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами равна  {max-min} ");

