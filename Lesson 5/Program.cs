// Задача № 34
int GetEvenNumbersCount(int[] array)
{
    var count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

//
Console.Clear();
var random = new Random();

//
Console.WriteLine("Задача № 34");
var arrayTaskThirtyFour = new int[5];
for (var i = 0; i < arrayTaskThirtyFour.Length; i++)
{
    arrayTaskThirtyFour[i] = random.Next(100, 1000);
}
Console.WriteLine($"[{string.Join(", ", arrayTaskThirtyFour)}]");
var evenCount = GetEvenNumbersCount(arrayTaskThirtyFour);
Console.WriteLine($"Количество чётных чисел в массиве - {evenCount}");