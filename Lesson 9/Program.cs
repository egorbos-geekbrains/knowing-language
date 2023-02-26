// Вспомогательные функции
int[]? GetValues()
{
    Console.Write($"\nВведите значения m, n разделяя пробелом: ");
    var values = Console.ReadLine()?.Split(" ").Select(e => int.Parse(e)).ToArray();
    return values;
}

// Задача № 66
int GetNumbersRangeSum(int start, int end)
{
    if(start == end) return end;
    return start + GetNumbersRangeSum(start + 1, end);
}

// Задача № 68
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if ((m != 0) && (n == 0)) return AckermannFunction(m - 1, 1);
        else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));    
    }
}

//
Console.Clear();
int[]? values;

//
Console.Write("Задача № 66");
values = GetValues();
while (values is null || values.Length < 2 || values.Any(e => e < 1))
{
    values = GetValues();
}
var rangeSumm = GetNumbersRangeSum(values[0], values[1]);
Console.WriteLine($"Сумма натуральных элементов в диапазоне от {values[0]} до {values[1]} равна {rangeSumm}");

//
Console.Write("\nЗадача № 68");
values = GetValues();
while (values is null || values.Length < 2 || values.Any(e => e < 1))
{
    values = GetValues();
}
var ackValue = AckermannFunction(values[0], values[1]);
Console.WriteLine($"A({values[0]}, {values[1]}) = {ackValue}");