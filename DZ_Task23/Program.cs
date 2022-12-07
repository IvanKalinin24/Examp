//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Ввидите число N: ");
int number = int.Parse(Console.ReadLine());
int B = 1;

for (B = 1; B <= number; B++)
{
    Console.Write($"{B*B*B} ");
}
Console.WriteLine();

