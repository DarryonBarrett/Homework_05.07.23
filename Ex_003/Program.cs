// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void Check(int[,] array, int[,] array2)
{
    if (array.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй матрицы! Умножение матриц невозможно!");
        Environment.Exit(0);
    }
}

int[,] MultiplyMatrix(int[,] array, int[,] array2)
{
    int[,] result = new int[array.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i, k] * array2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int rows = InpitNum("Введите количество строк: ");
int cols = InpitNum("Введите количество столбцов: ");
int minVal = InpitNum("Введите минимальное значение диапазона: ");
int maxVal = InpitNum("Введите максимальное значение диапазона: ");
int[,] myArray = Create2DArray(rows, cols);
Fill2DArray(myArray, minVal, maxVal);
int rows2 = InpitNum("Введите количество строк второго массива: ");
int cols2 = InpitNum("Введите количество столбцов второго массива: ");
int minVal2 = InpitNum("Введите минимальное значение диапазона второго массива: ");
int maxVal2 = InpitNum("Введите максимальное значение диапазона второго массива: ");
int[,] myArray2 = Create2DArray(rows2, cols2);
Fill2DArray(myArray2, minVal2, maxVal2);
Print2DArray(myArray);
Print2DArray(myArray2);
Check(myArray, myArray2);
int[,] resArray = MultiplyMatrix(myArray, myArray2);
Print2DArray(resArray);