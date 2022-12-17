using System;
using static System.Console;

Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
    Write(Akkerman(m, n)); 
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}