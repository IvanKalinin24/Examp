Console.Clear();
Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine());
int B = 1;

while (B <= N)
{ 
Console.Write(B+1);
B+=2;
}