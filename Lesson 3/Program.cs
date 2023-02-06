// Задача № 19
bool IsNumberPalindrome(int number)
{
    var tail = number % 100;
    return number / 1000 == tail / 10 + (tail % 10) * 10;
}

// Задача № 21
double Calc3dDistance(
    double x1, double y1, double z1,
    double x2, double y2, double z2
    )
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 -y2, 2) + Math.Pow(z1 - z2, 2));
}

// Задача № 23
int[] GetThirdPowerNumbersTable(int number)
{
    var numbers = new int[number];
    for (var i = 1; i <= number; i++)
    {
        numbers[i - 1] = (int) Math.Pow(i, 3);
    }
    return numbers;
}

// Дополнительная задача
int GetMaxBerriesCount(int[] bushes)
{
    var maxBerriesCount = 0;
    for (var i = 0; i <= bushes.Length - 3; i++)
    {
        var count = bushes[i] + bushes[i + 1] + bushes[i + 2];
        if (count > maxBerriesCount)
        {
            maxBerriesCount = count;
        }
    }
    return maxBerriesCount;
}

//
Console.Clear();
Console.WriteLine("Задача № 19");
Console.Write("Введите пятизначное число: ");
var taskNineteenNum = Convert.ToInt32(Console.ReadLine());

while (taskNineteenNum < 10000 || taskNineteenNum > 99999)
{
    Console.Write("Число должно быть пятизначным! Введите число: ");
    taskNineteenNum = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(IsNumberPalindrome(taskNineteenNum) ? "Да\n" : "Нет\n");

//
Console.WriteLine("Задача № 21");
Console.WriteLine("Введите координаты точки A.");
Console.Write("Координата X: ");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
var y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
var z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nВведите координаты точки B.");
Console.Write("Координата X: ");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
var y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
var z2 = Convert.ToDouble(Console.ReadLine());

var distance = Calc3dDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"{Math.Round(distance, 2)}\n");

//
Console.WriteLine("Задача № 23");
Console.Write("Введите число: ");
var taskTwentyThreeNum = Convert.ToInt32(Console.ReadLine());

while (taskTwentyThreeNum < 1)
{
    Console.Write("Число должно быть больше нуля! Введите число: ");
    taskTwentyThreeNum = Convert.ToInt32(Console.ReadLine());
}

var numbers = GetThirdPowerNumbersTable(taskTwentyThreeNum);
Console.WriteLine(string.Join(", ", numbers));

//
Console.WriteLine("\nДополнительная задача");
Console.Write("Введите количество кустов: ");
var bushCount = Convert.ToInt32(Console.ReadLine());

while (bushCount < 3 || bushCount > 1000)
{
    Console.Write("Количество должно быть в диапазоне [3; 1000]! Введите количество кустов: ");
    bushCount = Convert.ToInt32(Console.ReadLine());
}

var bushes = new int[bushCount];
for (var i = 0; i < bushCount; i++)
{
    Console.Write($"Введите количество ягод растущих на {i + 1} кусте: ");
    bushes[i] = Convert.ToInt32(Console.ReadLine());
    while (bushes[i] < 1)
    {
        Console.Write("Количество должно быть в диапазоне [1; 1000]! Введите количество ягод: ");
        bushes[i] = Convert.ToInt32(Console.ReadLine());
    }
}

var maxBerriesCount = GetMaxBerriesCount(bushes);
Console.WriteLine(maxBerriesCount);