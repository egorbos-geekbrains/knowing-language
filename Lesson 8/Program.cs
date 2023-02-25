// Вспомогательные функции
void Input2DMatrix<T>(T[,] matrix, Func<T> generator)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = generator();
        }
    }
}

void Print2DMatrix<T>(T[,] matrix, string separator = " \t")
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}{separator}");
        }
        Console.WriteLine();
    }
}

// Задача № 54
void SortMatrixByDescending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (var j = 1; j < matrix.GetLength(1); ++j)
        {
            var k = j;
            var max = matrix[i, j];            
            while (k > 0 && matrix[i, k - 1] < max)
            {
                matrix[i, k] = matrix[i, k - 1];
                --k;
            }
            matrix[i, k] = max;
        }
    }
}

//
Console.Clear();
var random = new Random();

//
Console.WriteLine("Задача № 54");
var matrixTaskFiftyFour = new int[3, 4];
Input2DMatrix(matrixTaskFiftyFour, () => random.Next(1, 10));
Console.WriteLine("Массив до преобразования:");
Print2DMatrix(matrixTaskFiftyFour);
SortMatrixByDescending(matrixTaskFiftyFour);
Console.WriteLine("Массив после преобразования:");
Print2DMatrix(matrixTaskFiftyFour);