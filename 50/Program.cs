void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWhithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }
    return result;
}


int SearchPosition(int[,] array, int line, int column)
{
    int result = array[line, column];
    return result;
}

int ReadInputData(string info)
{
    Console.WriteLine(info);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Всё плохо");
    return result;
}

int numberOfLines = ReadInputData("ВВедите число строк (m) ");

int numberOfColumns = ReadInputData("ВВедите число столбцов (m) ");

var array = CreateArrayWhithRandomNumbers(numberOfColumns, numberOfLines);
PrintArray(array);

Console.WriteLine();

int line = ReadInputData("Введите строку элемента");
int column = ReadInputData("Введите столбец элемента");

if (line > numberOfLines && column > numberOfColumns)
{
    Console.WriteLine("Данные значения не существуют в массиве ");
    return;
}

var result = SearchPosition(array, line, column);
Console.WriteLine($"В строке {line} и колонке {column} массива находится число {result}");
