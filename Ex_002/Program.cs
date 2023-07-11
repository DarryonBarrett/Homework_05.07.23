// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

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

int[] FindSums(int[,] array)
{
    int id = 0;
    int[] sums = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sums[id] = sum;
        id++;
    }
    return sums;
}


void PrintArray(int[] array)
{
    Console.Write("Суммы строк (соответственно) равны: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindMin(int[] array)
{
    int temp = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            temp = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {temp + 1}.");
}

int n = InpitNum("Введите длину прямоугольного массива: ");
int minVal = InpitNum("Введите минимальное значение диапазона: ");
int maxVal = InpitNum("Введите максимальное значение диапазона: ");
int[,] myArray = Create2DArray(n, n);
Fill2DArray(myArray, minVal, maxVal);
Print2DArray(myArray);
int[] rowSums = FindSums(myArray);
PrintArray(rowSums);
FindMin(rowSums);