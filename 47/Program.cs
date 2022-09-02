void PrintArray(double[,] array)
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

double[,] CreateArrayWithRandomNumbers(int m, int n)
{
    double[,] result = new double[m, n];

    var random = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.NextDouble()*100;
        }
    }

    return result;
}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out int m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out int n))
{
    Console.WriteLine("Всё плохо");
}


PrintArray(CreateArrayWithRandomNumbers(m, n));