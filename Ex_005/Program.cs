// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateArray()
{
    int n = 4; 
    int[,] array = new int[n, n]; 
    return array;
}

void FillArray(int[,] array)
{
    int n = array.GetLength(0);
    int num = 1; 
    int rowStart = 0; 
    int rowEnd = n - 1; 
    int colStart = 0; 
    int colEnd = n - 1;

    while (num <= n * n)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = num++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = num++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = num++;
        }
        colStart++;
    }
}
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] myArray = CreateArray();
FillArray(myArray);
Print2DArray(myArray);