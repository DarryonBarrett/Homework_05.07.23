// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Вариант без ввода данных:

// int[,,] Create3DArray()
// {
//     return new int[2, 2, 2];
// }

// void Fill3DArray(int[,,] array)
// {
//     int count = 10;
//     int[] usedNumbers = new int[2*2*2];
//     for (int i = 0; i < 2; i++)
//         for (int j = 0; j < 2; j++)
//             for (int k = 0; k < 2; k++)
//             {
//                 array[i,j,k] = count;
//                 count++;
//             }
// }

// void Print3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
//             Console.WriteLine();
//         }
//     }
//     Console.WriteLine();
// }

// int[,,] myArray = Create3DArray();
// Fill3DArray(myArray);
// Print3DArray(myArray);


// Вариант с вводом данных:

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,,] Create3DArray(int row, int col, int lay)
{
    return new int[row, col, lay];
}

void Fill3DArray(int[,,] array)
{
    Random rnd = new Random();
    HashSet<int> usedNumbers = new HashSet<int>();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int randomNumber = 0;
                do
                {
                    randomNumber = rnd.Next(10, 99);
                } 
                while (usedNumbers.Contains(randomNumber));
                array[i,j,k] = randomNumber;
                usedNumbers.Add(randomNumber);
            }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int rows = InputNum("Введите количество строк массива: ");
int cols = InputNum("Введите количество столбцов массива: ");
int layers = InputNum("Введите количество слоёв массива: ");
int[,,] myArray = Create3DArray(rows, cols, layers);
Fill3DArray(myArray);
Print3DArray(myArray);