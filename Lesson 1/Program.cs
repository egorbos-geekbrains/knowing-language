// Задача № 2
void MinMaxFind(int firstNumber, int secondNumber)
{
    var min = firstNumber < secondNumber ? firstNumber : secondNumber;
    var max = firstNumber == min ? secondNumber : firstNumber;
    Console.WriteLine($"MIN: {min}, MAX: {max}");
}

// Задача № 4
void MaxFromThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
{
    var maxOne = firstNumber > secondNumber ? firstNumber : secondNumber;
    var maxResult = maxOne > thirdNumber ? maxOne : thirdNumber;
    Console.WriteLine($"{maxResult}");
}

// Задача № 6
bool IsNumberEven(int number)
{
    return number % 2 == 0;
}

// Задача № 8
void GetEvenNumbers(int number)
{
    int currentNumber = 0;
    while (currentNumber < number) 
    {
        currentNumber++;
        if (currentNumber % 2 == 0)
        {
            Console.Write(currentNumber);
        }
        else if (currentNumber > 1 && currentNumber != number)
        {
            Console.Write(", ");
        }
    }
}

Console.Clear();
Console.WriteLine("Задача № 2");
Console.Write("Введите 1-ое число: ");
var taskTwoFirstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
var taskTwoSecondNum = Convert.ToInt32(Console.ReadLine());

MinMaxFind(taskTwoFirstNum, taskTwoSecondNum);

Console.WriteLine();
Console.WriteLine("Задача № 4");
Console.Write("Введите 1-ое число: ");
var taskFourFirstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
var taskFourSecondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
var taskFourThirdNum = Convert.ToInt32(Console.ReadLine());

MaxFromThreeNumbers(taskFourFirstNum, taskFourSecondNum, taskFourThirdNum);

Console.WriteLine();
Console.WriteLine("Задача № 6");
Console.Write("Введите число: ");
var taskSixNum = Convert.ToInt32(Console.ReadLine());

var isEven = IsNumberEven(taskSixNum);
Console.WriteLine(isEven ? "да" : "нет");

Console.WriteLine();
Console.WriteLine("Задача № 8");
Console.Write("Введите число: ");
var taskEightNum = Convert.ToInt32(Console.ReadLine());

while (taskEightNum < 0)
{
    Console.Write("Число должно быть положительным! Введите число: ");
    taskEightNum = Convert.ToInt32(Console.ReadLine());
}

GetEvenNumbers(taskEightNum);