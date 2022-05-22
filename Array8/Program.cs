// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

// Заполнение массива
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Поиск среднего арифметического каждого столбца
double[] AverageColumnElements(int[,] array)
{
    double[] averElements = new double[array.GetLength(1)];
    double sumElements = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumElements = sumElements + array[i, j];
        }
        averElements[j] = Math.Round(sumElements / array.GetLength(0),3);
    }
    return averElements;
}

// Печать среднеарифметических элементов каждого столбца исходного массива
void PrintAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое {i} столбца = {array[i]}");
    }
}

int M = 3;
int N = 3;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
double[] Average = AverageColumnElements(Array);
PrintAverage(Average);

