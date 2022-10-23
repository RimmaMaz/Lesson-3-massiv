// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

int [] GetArray(int size, int minval, int maxval)
{
    int[] array=new int[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(minval, maxval);
    } 
    return array;
}

void Sortarray(int[] array)
{
    int temp=0;
    for(int i=0; i<array.Length; i++)
    {
        for(int j=i+1; j<array.Length; j++)
        {
            if(array[i]<array[j])
            {
                temp=array[i];
                array[i]=array[j];  
                array[j]=temp;
            }
        }
    }
}

Console.WriteLine("ВВедите длину массива");

int a = int.Parse(Console.ReadLine()!);

int[] array = GetArray(a, -10, 20);


Console.WriteLine(string.Join(",", array));

Sortarray(array);

Console.WriteLine("Отсортированный массив: ");

Console.WriteLine(string.Join(" ", array));


