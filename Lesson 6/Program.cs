// Рекурсия
int GetFactorial(int number)
{
    return number == 1 ? 1 : number * GetFactorial(number - 1);
}

string[] GetPermutes(string text)
{
    var currentIndex = 0;
    var permutes = new string[GetFactorial(text.Length)];    
    void permute(char[] chars, int length, string currentPermute = "")
    {
        foreach (var character in chars.Reverse())
        {
            var permuteText = currentPermute;
            if(permuteText.Length == chars.Length)
            {
                permutes[currentIndex] = permuteText;
                currentIndex++;
            }
            if (length == 0)
            {
                return;
            }
            if (!currentPermute.Contains(character))
            {
                permuteText += character;
            }
            permute(chars, length - 1, permuteText);
        }
    };
    permute(text.ToCharArray(), text.Length);
    return permutes;
}

//
Console.Clear();

//
Console.Write("\nЗадача № 41");
var parsed = true;
var parseResult = 0;
var positiveCount = 0;
while (parsed)
{
    Console.Write($"\nВведите число (или введите любой символ для окончания ввода): ");
    parsed = int.TryParse(Console.ReadLine(), out parseResult);
    if (parseResult > 0)
    {
        positiveCount++;
    }
}
Console.WriteLine($"Количество чисел больше нуля: {positiveCount}");

//
Console.WriteLine("\nЗадача № 43");
Console.Write("k1=");
var kOne = Convert.ToDouble(Console.ReadLine());
Console.Write("b1=");
var bOne = Convert.ToDouble(Console.ReadLine());
Console.Write("k2=");
var kTwo = Convert.ToDouble(Console.ReadLine());
Console.Write("b2=");
var bTwo = Convert.ToDouble(Console.ReadLine());

if (kOne != kTwo)
{
    var x = (bTwo - bOne) / (kOne - kTwo);
    var y = (kOne * (bTwo - bOne)) / (kOne - kTwo) + bOne;
    Console.WriteLine($"Точка пересечения имеет координаты ({x}; {y})");
}
else if (bOne == bTwo)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    Console.WriteLine("Прямые параллельны");
}

//
Console.WriteLine("\nРекурсия");
Console.Write("Введите исходную строку: ");
var text = Console.ReadLine()?.ToUpperInvariant();
while (text is null || text.Trim().Length == 0 || text.Trim().Length > 8)
{
    Console.Write("Длина строки должна быть в диапазоне [1; 8]! Введите исходную строку: ");
    text = Console.ReadLine()?.ToUpperInvariant();
}
var permutes = GetPermutes(text);
Console.WriteLine("Возможные перестановки:");
foreach (var item in permutes)
{
    Console.WriteLine(item);
}