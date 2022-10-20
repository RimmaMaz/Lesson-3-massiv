//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Показать 2юу цифру трехзначного числа");
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int result = 0;
int a1 = a/10;

if (a1>=10 && a1<100)
{
    result = a%100/10;
    Console.WriteLine($"Вторая цифра чила {a} -> {result}");
}
else
{
    Console.WriteLine("введенное число не трехзначное");
}
