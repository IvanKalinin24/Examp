// //Здайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// //Aₘₙ = m+n. Выведите полученный массив на экран.

// using System;
// using static System.Console;

// Clear();

// int m = 3;
// int n = 4;


// int[,] array = GetArray(m, n);
// PrintArray(array);

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i+j;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i,j]} ");
//         }
//         WriteLine();
//     }
// }


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


// using System;
// using static System.Console;


// Clear();

// Write("Введите количество строк массива: ");
// int rows=int.Parse(ReadLine());

// Write("Введите количество столбцов массива: ");
// int columns=int.Parse(ReadLine());
// int[,] ChangeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i > 0 && i % 2 == 1 && j > 0 && j% 2 == 1)
//             {
//                 array[i, j] *= array[i, j];
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write($"{array[i, j]} ");
//         }
//         WriteLine();
//     }
// }

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i > 0 && i % 2 == 1 && j > 0 && j% 2 == 1)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}

