// В матрице чисел найти сумму элементов главной диагонали.

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
            array[i, j] = new Random().Next(-9, 10);
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

// Поиск суммы элементов главной диагонали
int SumMainDiagonalElements(int[,] array)
{
    int sum = 0;
    if (array.GetLength(1) > array.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sum = sum + array[i, i];
    }
    else
    {
        for (int i = 0; i < array.GetLength(1); i++)
            sum = sum + array[i, i];
    }
    return sum;
}

int M = 4;
int N = 3;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов главной диагонали = {SumMainDiagonalElements(Array)}");



