// Задача № 19
bool IsNumberPalindrome(int number)
{
    var tail = number % 100;
    return number / 1000 == tail / 10 + (tail % 10) * 10;
}

Console.Clear();
Console.WriteLine("Задача № 19");
Console.Write("Введите пятизначное число: ");
var taskNineteenNum = Convert.ToInt32(Console.ReadLine());

while (taskNineteenNum < 10000 || taskNineteenNum > 99999)
{
    Console.Write("Число должно быть пятизначным! Введите число: ");
    taskNineteenNum = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(IsNumberPalindrome(taskNineteenNum) ? "Да" : "Нет");