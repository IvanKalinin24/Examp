//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Ввидите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите число B: ");
int numberB = int.Parse(Console.ReadLine());

int i = 1;

int result = 1;
for (i = 1; i <= numberB; i++)
{
    result = result * numberA;
}

Console.WriteLine($"Ответ {result}");