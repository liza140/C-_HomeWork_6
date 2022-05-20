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
    int Sum = 0;
    if (array.GetLength(0) < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Sum = Sum + array[i, i];
        }
    }
    else
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Sum = Sum + array[i, i];
        }
    }
    return Sum;
}

int M = 4;
int N = 3;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
Console.Write($"Сумма элементов главной диагонали = ");
Console.WriteLine(SumMainDiagonalElements(Array));


