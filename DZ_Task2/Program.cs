int num1 = new Random().Next(1, 10);
Console.WriteLine(num1);
int num2 = new Random().Next(1, 10);
Console.WriteLine(num2);
int max = num1;

if(num1 > max) max = num1;
if(num2 > max) max = num2;

Console.Write("max = ");
Console.WriteLine(max); 