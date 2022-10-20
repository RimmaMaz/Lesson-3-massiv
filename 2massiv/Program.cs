// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Показать вторую цифру трехзначного числа");
Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine()!);
int result = 0;
int x1 = x/10;
if ( x1 >= x/10 && x1 < 100)
{
    result = (x%100)/10;
    Console.WriteLine($"Вторая цифра чсла {x} -> {result}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}


