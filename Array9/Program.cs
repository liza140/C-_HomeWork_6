// Написать программу, которая обменивает элементы первой строки и последней строки.

// Создание массива
int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
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

// Обмен строк массива
void ReplaceRows(int[,] array, int row1, int row2)
{
    int bufer = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        bufer = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = bufer;
    }
}



int M = 3;
int N = 3;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
int Row1 = 0;
int Row2 = 2;
ReplaceRows(Array, Row1, Row2);
PrintArray(Array);



