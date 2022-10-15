//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int Sum(int a)
{
    int result = 0;

    while (a > 0)
    {
        result = result + (a % 10);
        a = a / 10;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число ...");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {A} равна {Sum(A)}");




