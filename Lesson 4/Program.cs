// Задача № 25
int Pow(int x, int y)
{
    var result = x;
    var pow = y > 0 ? y : y * (-1);
    while (pow > 1)
    {
        pow -= 1;
        result *= x;
    }
    return result;
}

// Задача № 27
int GetDigitsSumm(int number)
{
    var result = 0;
    while (number > 0)
    {
        result = result + (number % 10);
        number = number / 10;
    }
    return result;
}

//
Console.Clear();
Console.WriteLine("Задача № 25");
Console.Write("Введите число A: ");
var taskTwentyFiveNumA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
var taskTwentyFiveNumB = Convert.ToInt32(Console.ReadLine());

while (taskTwentyFiveNumB == 0)
{
    Console.Write("Число должно быть отличным от нуля! Введите число B: ");
    taskTwentyFiveNumB = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(Pow(taskTwentyFiveNumA, taskTwentyFiveNumB));

//
Console.WriteLine("Задача № 27");
Console.Write("Введите число: ");
var taskTwentySevenNum = Convert.ToInt32(Console.ReadLine());

while (taskTwentySevenNum < 10)
{
    Console.Write("Число должно иметь более двух знаков! Введите число: ");
    taskTwentySevenNum = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(GetDigitsSumm(taskTwentySevenNum));