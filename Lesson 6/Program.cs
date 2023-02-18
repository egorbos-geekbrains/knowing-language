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