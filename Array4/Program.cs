// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] CreateArray (int M, int N)
{
    int[,] array = new int [M,N];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=i+j;
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m=3;
int n=4;
int[,] Arr=CreateArray (m,n);
PrintArray (Arr);

