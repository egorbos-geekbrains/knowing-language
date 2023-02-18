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

// Задача № 36
int GetOddPositionItemsSumm(int[] array)
{
    var summ = 0;
    for (var i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
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

//
Console.WriteLine("\nЗадача № 36");
var arrayTaskThirtySix = new int[5];
for (var i = 0; i < arrayTaskThirtySix.Length; i++)
{
    arrayTaskThirtySix[i] = random.Next(-100, 101);
}
Console.WriteLine($"[{string.Join(", ", arrayTaskThirtySix)}]");
var oddPositionItemsSumm = GetOddPositionItemsSumm(arrayTaskThirtySix);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {oddPositionItemsSumm}");