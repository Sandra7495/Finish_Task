using static System.Console;
Clear();

Write("Введите слова или числа через пробел: ");
string[] startArray = ReadLine().Split(" ");
WriteLine($"Начальный массив = {String.Join (" ", startArray)}");