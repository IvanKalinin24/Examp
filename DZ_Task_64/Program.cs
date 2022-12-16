using System;
using static System.Console;


Clear();

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());
int m=1;

WriteLine(PrintNumbers(m,n));

string PrintNumbers(int start, int end)
{
    if (end == start) 
        return end.ToString();
    return (PrintNumbers(start + 1, end)+ " " + start);
}