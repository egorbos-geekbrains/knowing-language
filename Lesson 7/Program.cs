// Вспомогательные функции
void InputMatrix<T>(T[,] matrix, Func<T> generator)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = generator();
        }
    }
}

void PrintMatrix<T>(T[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

// Задача № 52
double[] CalculateColumnsAverage(int[,] matrix)
{
    var averages = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        var average = .0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average += matrix[j, i];
        }
        averages[i] = Math.Round(average / matrix.GetLength(0), 1);
    }
    return averages;
}

//
Console.Clear();
var random = new Random();

//
Console.WriteLine("Задача № 47");
const double MinValue = -10;
const double MaxValue =  10;
var matrixTaskFortySeven = new double[3, 4];
InputMatrix(
    matrixTaskFortySeven,
    () => Math.Round(random.NextDouble() * (MaxValue - MinValue) + MinValue, 2)
);
PrintMatrix(matrixTaskFortySeven);

//
Console.WriteLine("\nЗадача № 50");
var matrixTaskFifty = new int[3, 4];
InputMatrix(matrixTaskFifty, () => random.Next(1, 10));
PrintMatrix(matrixTaskFifty);
Console.Write("Введите позицию элемента: ");
var coordinates = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();
while (coordinates is null || coordinates.Length < 2 || coordinates.Any(e => e < 1))
{
    Console.Write("Введите позицию элемента: ");
    coordinates = Console.ReadLine()?.Split(" ").Select(x => int.Parse(x)).ToArray();
}
if (matrixTaskFifty.GetLength(0) < coordinates[0] || matrixTaskFifty.GetLength(1) < coordinates[1])
{
    Console.WriteLine("Такой позиции в массиве нет");
} 
else
{
    Console.WriteLine($"На данной позиции находится элемент {matrixTaskFifty[coordinates[0] - 1, coordinates[1] - 1]}");
}

//
Console.WriteLine("\nЗадача № 52");
var matrixTaskFiftyTwo = new int[3, 4];
InputMatrix(matrixTaskFiftyTwo, () => random.Next(1, 10));
PrintMatrix(matrixTaskFiftyTwo);
var averageValues = CalculateColumnsAverage(matrixTaskFiftyTwo);
Console.Write($"Среднее арифметическое каждого столбца: {string.Join("; ", averageValues)}");