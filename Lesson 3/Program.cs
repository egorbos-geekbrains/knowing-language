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

Console.WriteLine("Задача № 21");
Console.WriteLine("Введите координаты точки A.");
Console.Write("Координата X: ");
var x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
var y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
var z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B.");
Console.Write("Координата X: ");
var x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Y: ");
var y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координата Z: ");
var z2 = Convert.ToDouble(Console.ReadLine());

var distance = Calc3dDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"{Math.Round(distance, 2)}\n");