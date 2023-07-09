// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GenerateRandomArray2D()
{
    int rows = new Random().Next(3, 10);
    int cols = new Random().Next(3, 10);
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

void FindAndPrintRowMinimalSum(int[,] numbers)
{
    int minSumRow = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum += numbers[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: ({minSumRow + 1})-я строка");
}

int[,] array = GenerateRandomArray2D();
PrintArray2D(array);
FindAndPrintRowMinimalSum(array);