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