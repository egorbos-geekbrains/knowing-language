//
Console.Clear();
var random = new Random();

//
Console.Write("\nЗадача № 41");
var parsed = true;
var parseResult = 0;
var positiveCount = 0;
while (parsed)
{
    Console.Write($"\nВведите число (или любой символ для окончания ввода): ");
    parsed = int.TryParse(Console.ReadLine(), out parseResult);
    if (parseResult > 0)
    {
        positiveCount++;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {positiveCount}");

//
Console.WriteLine("\nЗадача № 43");
Console.Write("k1=");
var kOne = Convert.ToDouble(Console.ReadLine());
Console.Write("b1=");
var bOne = Convert.ToDouble(Console.ReadLine());
Console.Write("k2=");
var kTwo = Convert.ToDouble(Console.ReadLine());
Console.Write("b2=");
var bTwo = Convert.ToDouble(Console.ReadLine());

if (kOne != kTwo)
{
    var x = (bTwo - bOne) / (kOne - kTwo);
    var y = (kOne * (bTwo - bOne)) / (kOne - kTwo) + bOne;
    Console.WriteLine($"Точка пересечения имеет координаты ({x}; {y})");
}
else if (bOne == bTwo)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    Console.WriteLine("Прямые параллельны");
}