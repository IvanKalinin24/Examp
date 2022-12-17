using System;
using static System.Console;


Clear();
Write("Введите M: ");
int m=int.Parse(ReadLine());
Write("Введите N: ");
int n=int.Parse(ReadLine());

WriteLine(PrintSum(m,n));

int PrintSum(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m + 1)) / 2;       
    else if (m == n) return m;                       
    else if (m < n) return n + PrintSum(m, n - 1); 
    else return n + PrintSum(m, n + 1);            
}
