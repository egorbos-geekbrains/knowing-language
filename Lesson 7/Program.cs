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

// Задача № 47


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