// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
using static System.Console;

Clear();

int[,] array = new int [4,4];
FillArrayRandomNumbers(array);
PrintArray(array);
StringMinSum(array);
WriteLine();

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    
}

void StringMinSum(int[,] array){
    int min = 0;
    int minSum = 0;
    int sum = 0;
    for (int i=0; i<array.GetLength(1); i++){
        min += array[0,1];
    }
    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            if (sum<min){
                min=sum;
                minSum=i;
            }
            sum=0;
        }
    }
    Write($"{minSum + 1} строка");
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
    }
}