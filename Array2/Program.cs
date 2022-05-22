// Показать двумерный массив размером m×n, заполненный вещественными числами.

// Создание массива
double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

// Заполнение массива
void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 3);
        }
    }
}

// Печать массива
void PrintArray(double[,] array)
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

int M = 3;
int N = 4;
double[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);

