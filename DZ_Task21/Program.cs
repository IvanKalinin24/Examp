//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int X = ReadInt("Ввидите координаты X: ");
int Y = ReadInt("Ввидите координаты Y: ");
int Z = ReadInt("Ввидите координаты Z: ");
int X1 = ReadInt("Ввидите координаты X1: ");
int Y1 = ReadInt("Ввидите координаты Y1: ");
int Z1= ReadInt("Ввидите координаты Z1: ");
double d = Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2) + Math.Pow(Z1 - Z, 2));
Console.WriteLine($"d = {d:f3}");









