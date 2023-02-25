// Вспомогательные функции
void Input2DMatrix<T>(T[,] matrix, Func<T> generator)
{
    var rowsCount = matrix.GetLength(0);
    var columnsCount = matrix.GetLength(1);

    for (var i = 0; i < rowsCount; i++)
    {
        for (var j = 0; j < columnsCount; j++)
        {
            matrix[i, j] = generator();
        }
    }
}

void Print2DMatrix<T>(T[,] matrix, string separator = " \t")
{
    var rowsCount = matrix.GetLength(0);
    var columnsCount = matrix.GetLength(1);

    for (var i = 0; i < rowsCount; i++)
    {
        for (var j = 0; j < columnsCount; j++)
        {
            Console.Write($"{matrix[i, j]}{separator}");
        }
        Console.WriteLine();
    }
}

// Задача № 54
void SortMatrixByDescending(int[,] matrix)
{
    var rowsCount = matrix.GetLength(0);
    var columnsCount = matrix.GetLength(1);

    for (var i = 0; i < rowsCount; i++)
    {
        for (var j = 1; j < columnsCount; ++j)
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

// Задача № 56
int GetMinSummValueRowNumber(int[,] matrix)
{
    var rowNumber = 0;

    int rowSumm;
    var prevRowSumm = 0;

    var rowsCount = matrix.GetLength(0);
    var columnsCount = matrix.GetLength(1);

    for (var i = 0; i < rowsCount; i++)
    {          
        rowSumm = 0;
        for (var j = 0; j < columnsCount; ++j)
        {
            rowSumm += matrix[i, j];
        }
        if (rowSumm < prevRowSumm)
        {
            rowNumber = i + 1;
        }
        prevRowSumm = rowSumm;
    }
    return rowNumber;
}

// Задача № 58
int[,] MultiplyMatrices(int[,] first, int[,] second)
{
    var tempValue = 0;
    var rowsCount = first.GetLength(0);
    var columnsCount = first.GetLength(1);
    var result = new int[rowsCount, columnsCount];
    for (var i = 0; i < rowsCount; i++)
    {
        for (var j = 0; j < columnsCount; j++)
        {
            tempValue = 0;
            for (int k = 0; k < columnsCount; k++)
            {
                tempValue += first[i, k] * second[k, j];
            }
            result[i, j] = tempValue;
        }
    }
    return result;
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

//
Console.WriteLine("\nЗадача № 56");
var matrixTaskFiftySix = new int[4, 3];
Input2DMatrix(matrixTaskFiftySix, () => random.Next(1, 10));
Print2DMatrix(matrixTaskFiftySix);
var rowNumber = GetMinSummValueRowNumber(matrixTaskFiftySix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowNumber}");

//
Console.WriteLine("\nЗадача № 58");
var matrixTaskFiftyEightFirst = new int[2, 2];
Input2DMatrix(matrixTaskFiftyEightFirst, () => random.Next(1, 5));
Console.WriteLine("Массив №1:");
Print2DMatrix(matrixTaskFiftyEightFirst);
var matrixTaskFiftyEightSecond = new int[2, 2];
Input2DMatrix(matrixTaskFiftyEightSecond, () => random.Next(1, 5));
Console.WriteLine("Массив №2:");
Print2DMatrix(matrixTaskFiftyEightSecond);
var multiplResult = MultiplyMatrices(matrixTaskFiftyEightFirst, matrixTaskFiftyEightSecond);
Console.WriteLine("Результат перемножения массивов:");
Print2DMatrix(multiplResult);