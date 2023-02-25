public partial class Program
{
    // Вспомогательные функции
    private static void Fill2DMatrix<T>(T[,] matrix, Func<T> generator)
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

    private static void Print2DMatrix<T>(T[,] matrix, string separator = " \t")
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

    private static void Fill3DMatrix<T>(T[,,] matrix, Func<T> generator)
    {
        var rowsCount = matrix.GetLength(0);
        var columnsCount = matrix.GetLength(1);
        var layersCount = matrix.GetLength(2);

        for (int i = 0; i < rowsCount; i++)
        {
            for (int j = 0; j < columnsCount; j++)
            {
                for (int k = 0; k < layersCount; k++)
                {
                    matrix[i, j, k] = generator();
                }
            }
        }
    }

    private static void Print3DMatrix<T>(T[,,] matrix)
    {
        var rowsCount = matrix.GetLength(0);
        var columnsCount = matrix.GetLength(1);
        var layersCount = matrix.GetLength(2);

        for (int i = 0; i < rowsCount; i++)
        {
            for (int j = 0; j < columnsCount; j++)
            {
                for (int k = 0; k < layersCount; k++)
                {
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }

    // Задача № 54
    private static void SortMatrixByDescending(int[,] matrix)
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
    private static int GetMinSummValueRowNumber(int[,] matrix)
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
    private static int[,] MultiplyMatrices(int[,] first, int[,] second)
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

    // Задача № 61
    private static void PrintPascalTriangleRows(int rowsCount)
    {    
        for (var rowNumber = 0; rowNumber < rowsCount; rowNumber++)
        {
            var number = 1;
            for (var i = 0; i < rowsCount - rowNumber; i++)
            {
                Console.Write("   ");
            }
        
            for (var element = 0; element <= rowNumber; element++)
            {
                Console.Write("   {0:D}  ", number);
                number = number * (rowNumber - element) / (element + 1);
            }
            Console.WriteLine("\n");
        }
    }



    // Задача № 62
    private enum SpiralFillDirection
    {
        Right,
        Down,
        Left,
        Up,
        Stop
    }

    private static void SpiralFill2DMatrix(int[,] matrix)
    {        
        var rowsCount = matrix.GetLength(0);
        var columnsCount = matrix.GetLength(1);
        var direction = SpiralFillDirection.Right;

        var value = 1;
        var rowNumber = 0;
        var columnNumber = 0;

        while (direction != SpiralFillDirection.Stop)
        {
            matrix[rowNumber, columnNumber] = value++;
            
            switch (direction)
            {
                case SpiralFillDirection.Right:
                    if (matrix[rowNumber + 1, columnNumber] != 0 && matrix[rowNumber, columnNumber + 1] != 0)
                    {
                        columnNumber++;
                        direction = SpiralFillDirection.Stop;                        
                    }
                    else if (columnNumber == columnsCount - 1 || matrix[rowNumber, columnNumber + 1] != 0)
                    {
                        rowNumber++;
                        direction = SpiralFillDirection.Down;                        
                    }
                    else
                    {
                        columnNumber++;
                    }
                    break;

                case SpiralFillDirection.Down:
                    if (rowNumber == rowsCount - 1 || matrix[rowNumber + 1, columnNumber] != 0)
                    {
                        columnNumber--;
                        direction = SpiralFillDirection.Left;                        
                    }
                    else
                    {
                        rowNumber++;
                    }
                    break;

                case SpiralFillDirection.Left:
                    if (matrix[rowNumber - 1, columnNumber] != 0 && matrix[rowNumber, columnNumber - 1] != 0)
                    {
                        columnNumber--;
                        direction = SpiralFillDirection.Stop;                        
                    }
                    else if (columnNumber == 0 || matrix[rowNumber, columnNumber - 1] != 0)
                    {
                        rowNumber--;
                        direction = SpiralFillDirection.Up;                        
                    }
                    else
                    {
                        columnNumber--;
                    }
                    break;

                case SpiralFillDirection.Up:
                    if (rowNumber == 1 || matrix[rowNumber - 1, columnNumber] != 0)
                    {
                        columnNumber++;
                        direction = SpiralFillDirection.Right;                        
                    }
                    else
                    {
                        rowNumber--;
                    }
                    break;
            }            
        }
    }

    static public void Main(String[] args)
    {
        //
        Console.Clear();
        var random = new Random();

        //
        Console.WriteLine("Задача № 54");
        var matrixTaskFiftyFour = new int[3, 4];
        Fill2DMatrix(matrixTaskFiftyFour, () => random.Next(1, 10));
        Console.WriteLine("Массив до преобразования:");
        Print2DMatrix(matrixTaskFiftyFour);
        SortMatrixByDescending(matrixTaskFiftyFour);
        Console.WriteLine("Массив после преобразования:");
        Print2DMatrix(matrixTaskFiftyFour);

        //
        Console.WriteLine("\nЗадача № 56");
        var matrixTaskFiftySix = new int[4, 3];
        Fill2DMatrix(matrixTaskFiftySix, () => random.Next(1, 10));
        Print2DMatrix(matrixTaskFiftySix);
        var rowNumber = GetMinSummValueRowNumber(matrixTaskFiftySix);
        Console.WriteLine($"Номер строки с наименьшей суммой элементов: {rowNumber}");

        //
        Console.WriteLine("\nЗадача № 58");
        var matrixTaskFiftyEightFirst = new int[2, 2];
        Fill2DMatrix(matrixTaskFiftyEightFirst, () => random.Next(1, 5));
        Console.WriteLine("Массив №1:");
        Print2DMatrix(matrixTaskFiftyEightFirst);
        var matrixTaskFiftyEightSecond = new int[2, 2];
        Fill2DMatrix(matrixTaskFiftyEightSecond, () => random.Next(1, 5));
        Console.WriteLine("Массив №2:");
        Print2DMatrix(matrixTaskFiftyEightSecond);
        var multiplResult = MultiplyMatrices(matrixTaskFiftyEightFirst, matrixTaskFiftyEightSecond);
        Console.WriteLine("Результат перемножения массивов:");
        Print2DMatrix(multiplResult);

        //
        Console.WriteLine("\nЗадача № 60");
        var matrixTaskSixty = new int[2, 2, 2];
        var values = new int[matrixTaskSixty.GetLength(0) * matrixTaskSixty.GetLength(1) * matrixTaskSixty.GetLength(2)];
        Fill3DMatrix(
            matrixTaskSixty, 
            () => {
                var rnd = random.Next(10, 100);
                while (values.Any(e => e == rnd))
                {
                    rnd = random.Next(10, 100);
                }
                return rnd;
            }
        );
        Print3DMatrix(matrixTaskSixty);

        //
        Console.Write("\nЗадача № 61");
        var parsed = false;
        var triangleRowsCount = 0;
        while (!parsed)
        {
            Console.Write($"\nВведите количество строк треугольника Паскаля:  ");
            parsed = int.TryParse(Console.ReadLine(), out triangleRowsCount);
        }
        PrintPascalTriangleRows(triangleRowsCount);

        //
        Console.WriteLine("\nЗадача № 62");
        var matrixTaskSixtyTwo = new int[4, 4];
        Fill2DMatrix(matrixTaskSixtyTwo, () => 0);
        Console.WriteLine("Массив до заполнения:");
        Print2DMatrix(matrixTaskSixtyTwo);
        SpiralFill2DMatrix(matrixTaskSixtyTwo);
        Console.WriteLine("Массив после заполнения:");
        Print2DMatrix(matrixTaskSixtyTwo);
    }
}