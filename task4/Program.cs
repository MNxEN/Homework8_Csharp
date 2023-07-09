// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] GenerateSpiraleArray2D(int n)
{
    int[,] numbers = new int[n, n];
    // Определяем границы массива
    int top = 0;
    int bottom = n - 1;
    int left = 0;
    int right = n - 1;
    // Задаем начальное значение и направление движения
    int num = 1;
    int direction = 0;
    while (top <= bottom && left <= right)
    {
        if (direction == 0)
        // Движение вправо
        {
            for (int i = left; i < right + 1; i++)
            {
                numbers[top, i] = num;
                num += 1;
            }
            top += 1;
        }
        else if (direction == 1)
        // Движение вниз
        {
            for (int i = top; i < bottom + 1; i++)
            {
                numbers[i, right] = num;
                num += 1;
            }
            right -= 1;
        }
        else if (direction == 2)
        // Движение влево
        {
            for (int i = right; i > left - 1; i--)
            {
                numbers[bottom, i] = num;
                num += 1;
            }
            bottom -= 1;
        }
        else if (direction == 3)
        // Движение вверх
        {
            for (int i = bottom; i > top - 1; i--)
            {
                numbers[i, left] = num;
                num += 1;
            }
            left += 1;
        }
        //Изменяем направление движения
        direction = (direction + 1) % 4;
    }
    return numbers;
}
int arrayDimension = PromptInt("Введите размерность спирального массива");
int[,] array = GenerateSpiraleArray2D(arrayDimension);
PrintArray2D(array);
