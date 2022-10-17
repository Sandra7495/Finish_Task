using static System.Console;
Clear();

Write("Введите слова или числа через пробел: ");
string[] startArray = ReadLine().Split(" ");
WriteLine($"Начальный массив = {String.Join (" ", startArray)}");

string[] resultArray = new string[startArray.Length];
void SecondArrayWithIF(string[] startArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
    if(startArray[i].Length <= 3)
        {
        resultArray[count] = startArray[i];
        count++;
        }
    }
}
SecondArrayWithIF(startArray,resultArray);
WriteLine($"Итоговый массив = {String.Join (" ", resultArray)}");