// using System;
// using static System.Console;

// Clear();

// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// ChangeRows(array);
// PrintArray(array);

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
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
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// void ChangeRows(int[,] inArray)
// {
//     int rowCount = inArray.GetLength(0) - 1;
//     for (int i = 0; i < inArray.GetLength(1); i++)
//     {
//         int k = inArray[0, i];
//         inArray[0, i] = inArray[rowCount, i];
//         inArray[rowCount, i] = k;
//     }
// }

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// using System;
// using static System.Console;

// Clear();

// Write("Введите количество строк массива: ");
// int rows = int.Parse(ReadLine());
// Write("Введите количество столбцов массива: ");
// int columns = int.Parse(ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();
// ChangeRows2(array);
// PrintArray(array);
// int i = 0;
// int j = 0;

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// void ChangeRows(int[,] inArray)
// {
//     int rowCount = inArray.GetLength(0) - 1;
//     for (int i = 0; i < inArray.GetLength(1); i++)
//     {
//         int k = inArray[0, i];
//         inArray[0, i] = inArray[rowCount, i];
//         inArray[rowCount, i] = k;
//     }
// }
// void ChangeRows2(int[,] inArray)
// {    
//     for(int i =0; i<array.GetLength(0); i++){
//         for (int j=i; j<array.GetLength(1); j++){
//             int l = array[j,i];
//             array [j,i]=array[i,j];
//             array [i,j] = l;
//     }
//     }
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }


// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
int[] rowAr=GetRowArray(array);
SortArray(rowAr);
WriteLine(String.Join(" ",rowAr));
PrintData(rowAr);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)*inArray.GetLength(1)];
    int index=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[i * inArray.GetLength(1) + j] = inArray[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i+1; j < inArray.Length; j++)
        {
            if(inArray[i]>inArray[j])
            {
                int k=inArray[i];
                inArray[i]=inArray[j];
                inArray[j]=k;
            }
        }
    }
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
void PrintData (int [] inArray){
    int el = inArray[0];
    int count = 1;
    for (int i = 1; i<inArray.Length; i++){
        if(inArray[i]!=el)
        {
            WriteLine($"{el} Встречается {count}");
            el=inArray[i];
            count=1;
        }
        else{
            count++;
        }
    }
    WriteLine($"{el} Встречается {count}");
}