// Задача № 10
void ShowSecondNumber(int number)
{
    Console.WriteLine(number % 100 / 10);
}

// Задача № 13
void ShowThirdNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        var exp = 10;
        var num = number;
        while (num > 1000)
        {
            num = num / 10;
            exp = exp * 10;
        }
        Console.WriteLine(number % exp / (exp / 10));
    }
}

// Задача № 15
void IsDayWeekend(int dayNumber)
{
    if (dayNumber < 6)
    {
        Console.WriteLine("Нет");
    }
    else
    {
        Console.WriteLine("Да");
    }
}

Console.Clear();
Console.WriteLine("Задача № 10");
Console.Write("Введите число: ");
var taskTenNum = Convert.ToInt32(Console.ReadLine());

while (taskTenNum < 100 || taskTenNum > 999)
{
    Console.Write("Число должно быть трёхзначным! Введите число: ");
    taskTenNum = Convert.ToInt32(Console.ReadLine());
}

ShowSecondNumber(taskTenNum);

Console.WriteLine("Задача № 13");
Console.Write("Введите число: ");
var taskThirteenNum = Convert.ToInt32(Console.ReadLine());

while (taskThirteenNum < 0)
{
    Console.Write("Число должно быть положительным! Введите число: ");
    taskThirteenNum = Convert.ToInt32(Console.ReadLine());
}

ShowThirdNumber(taskThirteenNum);

Console.WriteLine("Задача № 15");
Console.Write("Введите день недели: ");
var taskFifteenNum = Convert.ToInt32(Console.ReadLine());

while (taskFifteenNum < 1 || taskFifteenNum > 7)
{
    Console.Write("Число должно быть в диапазоне 1..7! Введите число: ");
    taskFifteenNum = Convert.ToInt32(Console.ReadLine());
}

IsDayWeekend(taskFifteenNum);

Console.WriteLine("Дополнительная задача");
Console.Write("Введите число: ");
var number = Convert.ToInt32(Console.ReadLine());
var prevMax = 0;
var currentMax = 0;
while (number != 0)
{    
    if (number < 0 || number > 100)
    {
        Console.Write("Число должно быть в диапазоне 1..100!");
    }
    else if (number > currentMax)
    {
        prevMax = currentMax;
        currentMax = number;
    }
    else if (number > prevMax)
    {
        prevMax = number;
    }
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());    
}
Console.WriteLine($"Ответ: {prevMax}");