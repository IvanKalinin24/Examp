using System;
using static System.Console;

Clear();

Write("Введите количество строк 1 матрицы: ");
int rows = int.Parse(ReadLine());
Write("ВВведите число столбцов 1-й матрицы (и строк 2-й): ");
int columns = int.Parse(ReadLine());
Write("Введите количество столбцов 2 матрицы: ");
int columns2 = int.Parse(ReadLine());


int[,] firstMartrix = new int[rows, columns];
CreateMatrix(firstMartrix);
WriteLine($"Матрица 1:"); 
WriteMatrix(firstMartrix);
int[,] secomdMartrix = new int[columns, columns2];
CreateMatrix(secomdMartrix);
WriteLine($"Матрица 2:");
WriteMatrix(secomdMartrix);

int[,] resultMatrix = new int[rows, columns2];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine($"Произведение первой и второй матриц:");
WriteMatrix(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
    }
  }
}

void WriteMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Write(matrix[i,j] + " ");
    }
    WriteLine();
  }
}