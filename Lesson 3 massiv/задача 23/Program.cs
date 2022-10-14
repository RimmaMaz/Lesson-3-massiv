//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Cube (int n)
{
    for (int i=1; i<=n; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}");
        if (i !=n)
        {
            Console.Write(", ");
        } 
    }
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Cube(N);

