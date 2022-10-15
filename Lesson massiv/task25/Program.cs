// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int Getarray(int A, int B)
{
    int result = 1;
    for (int i=1; i<=B; i++)
    {
        result=result*A;
    }
    return result;
}

Console.Clear();
Console.Write("Введите первое число ...");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число ...");
int b = int.Parse(Console.ReadLine()!);
Console.Write(Getarray(a, b));
