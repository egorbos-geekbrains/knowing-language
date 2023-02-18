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

// Задача № 38
double GetMaxMinItemsDifference(double[] array)
{
    var min = array[0];
    var max = array[0];
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max - min;
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

//
Console.WriteLine("\nЗадача № 38");
var arrayTaskThirtyEight = new double[5];
var minArrayValue = 1;
var maxArrayValue = 100;
for (var i = 0; i < arrayTaskThirtyEight.Length; i++)
{
    var item = random.NextDouble() * (maxArrayValue - minArrayValue) + minArrayValue;
    arrayTaskThirtyEight[i] = Math.Round(item, 2);
}
Console.WriteLine($"[{string.Join(", ", arrayTaskThirtyEight)}]");
var maxMinDifference = GetMaxMinItemsDifference(arrayTaskThirtyEight);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(maxMinDifference, 2)}");