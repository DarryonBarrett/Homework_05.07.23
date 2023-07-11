// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int InpitNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols)
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Change2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }

        Array.Sort(row);
        Array.Reverse(row);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
    }
}


int rows = InpitNum("Введите количество строк: ");
int cols = InpitNum("Введите количество столбцов: ");
int minVal = InpitNum("Введите минимальное значение диапазона: ");
int maxVal = InpitNum("Введите максимальное значение диапазона: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minVal, maxVal);
Print2DArray(myArray);
Change2DArray(myArray);
Print2DArray(myArray);