void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}
int ReadInputData(string info)
{
    Console.WriteLine(info);
    if (!int.TryParse(Console.ReadLine(), out var result))
        Console.WriteLine("Все плохо");
    return result;
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
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

void Arithmetic(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double result = sum / array.GetLength(0);
        Console.Write($"{result.ToString("F1")} ");
    }
}

int numberOfLines = ReadInputData("Введите число строк (m)");
int numberOfColumns = ReadInputData("Введите число столбцов (n)");

var array = CreateArrayWithRandomNumbers(numberOfLines, numberOfColumns);
PrintArray(array);
Console.WriteLine();
Arithmetic(array);