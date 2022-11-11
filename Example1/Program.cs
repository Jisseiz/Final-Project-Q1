// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам

Console.WriteLine("Введите массив строк через пробел");
string input = Console.ReadLine();
var arr = input.Split(' ');

var result = new string[arr.Length];
var realSize = 0;
foreach (var value in arr)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));