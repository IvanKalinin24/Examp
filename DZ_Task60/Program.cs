using System;
using static System.Console;

Clear();
WriteLine($"Введите размер массива: ");
WriteLine("Введите m: ");
int m = int.Parse(ReadLine()); 
WriteLine("Введите n: ");
int n = int.Parse(ReadLine()); 
WriteLine("Введите l: ");
int l = int.Parse(ReadLine()); 
WriteLine($"");

int[,,] array3 = new int[m, n, l];
CreateArray(array3);
GetArray(array3);


void GetArray (int[,,] array3)
{
  for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      Write($"({i} {j} ");
      for (int k = 0; k < array3.GetLength(2); k++)
      {
        Write( $"{k})={array3[i,j,k]}; ");
      }
      WriteLine();
    }
    WriteLine();
  }
}

void CreateArray(int[,,] array3)
{
  int[] temp = new int[array3.GetLength(0) * array3.GetLength(1) * array3.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(0, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(0, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3.GetLength(0); x++)
  {
    for (int y = 0; y < array3.GetLength(1); y++)
    {
      for (int z = 0; z < array3.GetLength(2); z++)
      {
        array3[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
