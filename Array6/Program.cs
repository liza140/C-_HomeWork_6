// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет.

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

// Поиск элемента массива
bool FindElements(int[,] array, int num)
{
    bool findElements = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num) findElements = true;
        }
    }
    return findElements;
}

// Поиск индекса массива
(int, int) FindIndex(int[,] array, int num)
{
    int indI = 0;
    int indJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                indI = i;
                indJ = j;
            }
        }
    }
    return(indI, indJ);
}

int M = 3;
int N = 4;
int Num = 8;
int[,] Array = CreateArray(M, N);
FillArray(Array);
PrintArray(Array);
Console.WriteLine();
bool logik = FindElements(Array, Num);
if (logik == true)
{
    Console.Write($"Позиция заданного пользователем числа ");
    Console.WriteLine(FindIndex(Array, Num));
}
else Console.WriteLine("Заданное пользователем число отсутсвует в массиве");


