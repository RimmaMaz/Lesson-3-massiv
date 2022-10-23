// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetarrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for(int i=0; i<nums.Length; i++)
    {
        res[i]=int.Parse(nums[i]);
    }
    return res;
}

int countPositive(int[] array)
{
    int count=0;
    foreach (int el in array)
    {
        if(el>0) count++;
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите числа через пробел");
string input = Console.ReadLine()!;
int[] array=GetarrayFromString(input);
int count=countPositive(array);
Console.WriteLine($"Чисел больше нуля: {count}");




