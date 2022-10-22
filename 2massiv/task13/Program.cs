// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int a1 = a/10;
int num = a;

if (a1>10 || a1<-10)
{
    while (a>999 || a<-999)
    {
        a = a/10;
    }
    if (a<0)
    {
        a=-a;
        Console.WriteLine("Третья цbфра трехзначного числа {num} -> {a%10} ");
    }
    else
    {
        Console.WriteLine("Третья цbфра трехзначного числа {num} -> {a%10} ");
    }
}
else
{
    Console.WriteLine("третьей цифры нет");
}

