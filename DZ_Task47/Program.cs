//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.

double[,] array = new double[3, 4];
Random random = new Random();
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array[i, j] = random.NextDouble() * 10; 
        Console.Write("{0,6:F2}", array[i, j]);
    }
    Console.WriteLine();
}