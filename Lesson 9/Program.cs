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

//
Console.Clear();
int[]? values;

//
Console.Write("\nЗадача № 66");
values = GetValues();
while (values is null || values.Length < 2 || values.Any(e => e < 1))
{
    values = GetValues();
}
var rangeSumm = GetNumbersRangeSum(values[0], values[1]);
Console.WriteLine($"Сумма натуральных элементов в диапазоне от {values[0]} до {values[1]} равна {rangeSumm}");