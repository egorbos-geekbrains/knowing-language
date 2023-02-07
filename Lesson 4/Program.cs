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

// Задача № 27
int GetDigitsSumm(int number)
{
    var result = 0;
    while (number > 0)
    {
        result = result + (number % 10);
        number = number / 10;
    }
    return result;
}

// Задача № 29
int GetPupilPosition(int[] pupils, int pupilHeight)
{
    if (pupils[0] < pupilHeight)
    {
        return 1;
    }
    var prevHeight = pupils[0];
    for (var i = 1; i < pupils.Length; i++)
    {
        if (pupilHeight <= prevHeight && pupilHeight > pupils[i])
        {
            return i + 1;
        }
        prevHeight = pupils[i];
    }
    return pupils.Length + 1;
}

// Суперсдвиг
int[] Supershift(int[] array, int level)
{
    var newArray = new int[array.Length];
    if (level < 0)
    {
        level *= (-1);
        level %= array.Length;
    }
    else
    {
        level %= array.Length;
        level = array.Length - level;
    }
    var index = 0;
    for (var i = level; i < array.Length; i++)
    {
        newArray[index] = array[i];
        index += 1;
    }
    for (var i = 0; i < level; i++)
    {
        newArray[index] = array[i];
        index += 1;
    }
    return newArray;
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

//
Console.WriteLine("\nЗадача № 27");
Console.Write("Введите число: ");
var taskTwentySevenNum = Convert.ToInt32(Console.ReadLine());

while (taskTwentySevenNum < 10)
{
    Console.Write("Число должно иметь более двух знаков! Введите число: ");
    taskTwentySevenNum = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(GetDigitsSumm(taskTwentySevenNum));

//
Console.WriteLine("\nЗадача № 29");
Console.Write("Введите количество учеников: ");
var pupilsCount = Convert.ToInt32(Console.ReadLine());

while (pupilsCount < 1 || pupilsCount > 100)
{
    Console.Write("Количество должно быть в диапазоне [1; 100]! Введите количество учеников: ");
    pupilsCount = Convert.ToInt32(Console.ReadLine());
}

var pupils = new int[pupilsCount];
for (var i = 0; i < pupilsCount; i++)
{
    Console.Write($"Введите рост ученика № {i + 1}: ");
    pupils[i] = Convert.ToInt32(Console.ReadLine());
    while (pupils[i] < 1 || (i != 0 && pupils[i] > pupils[i - 1]))
    {
        if (pupils[i] < 1)
        {
            Console.Write("Рост должен быть в диапазоне [1; 200]! Введите рост: ");
        }
        else
        {
            Console.Write("Рост должен быть меньше, чем у предыдущего ученика! Введите рост: ");
        }
        pupils[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите рост Пети: ");
var petyaHeight = Convert.ToInt32(Console.ReadLine());

while (petyaHeight < 1)
{
    Console.Write("Рост должен быть в диапазоне [1; 200]! Введите рост: ");
    petyaHeight = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(GetPupilPosition(pupils, petyaHeight));

//
Console.WriteLine("\nСуперсдвиг");
Console.Write("Введите количество чисел: ");
var numbersCount = Convert.ToInt32(Console.ReadLine());

while (numbersCount < 1 || numbersCount > 100000)
{
    Console.Write("Количество должно быть в диапазоне [1; 100000]! Введите количество чисел: ");
    numbersCount = Convert.ToInt32(Console.ReadLine());
}

var numbers = new int[numbersCount];
for (var i = 0; i < numbersCount; i++)
{
    Console.Write($"Введите значение для числа № {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
    while (Math.Abs(numbers[i]) > 100)
    {
        Console.Write("Значение должно быть в диапазоне [-100; 100]! Введите значение: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Write("Введите уровень сдвига: ");
var shiftLevel = Convert.ToInt32(Console.ReadLine());

while (Math.Abs(shiftLevel) > 100000)
{
    Console.Write("Значение должно быть в диапазоне [-100000; 100000]! Введите уровень сдвига: ");
    numbersCount = Convert.ToInt32(Console.ReadLine());
}

var shiftedArray = Supershift(numbers, shiftLevel);
Console.WriteLine(string.Join(" ", shiftedArray));