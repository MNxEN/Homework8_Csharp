// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int PromptInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}

int[,] GenerateArray2D(int rows, int cols)
{
    int[,] numbers = new int[rows, cols];
    Random rndVal = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rndVal.Next(-30, 51);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void MatrixProduct(int[,] numbers1, int[,] numbers2)
{
    int rows1 = numbers1.GetLength(0);
    int cols1 = numbers1.GetLength(1);

    int rows2 = numbers2.GetLength(0);
    int cols2 = numbers2.GetLength(1);

    if (cols1 != rows2)
    {
        Console.WriteLine("Умножение матриц невозможно");
        return;
    }

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += numbers1[i, k] * numbers2[k, j];
            }
            result[i, j] = sum;
        }
    }

    Console.WriteLine("Результирующая матрица:");

    PrintArray2D(result);
}
int rows1 = PromptInt("Введите количество строк первого массива");
int cols1 = PromptInt("Введите количество столбцов первого массива");
int rows2 = PromptInt("Введите количество строк второго массива");
int cols2 = PromptInt("Введите количество столбцов второго массива");
int[,] array1 = GenerateArray2D(rows1, cols1);
PrintArray2D(array1);
int[,] array2 = GenerateArray2D(rows2, cols2);
PrintArray2D(array2);
MatrixProduct(array1, array2);