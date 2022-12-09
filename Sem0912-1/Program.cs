// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// 💡 Комментарий: эту задачу можно решить 2 способами:
// 1) менять числа местами в исходном массиве; 
//2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
// Рассмотрите плюсы и минусы обоих вариантов



// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
// Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray = ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));
// }
// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// <aside>
// ❗️ Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// </aside>

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         static void Main()
//         {
//             Console.Write("Введите сторону a: ");
//             double a = double.Parse(Console.ReadLine());
//             Console.Write("Введите сторону b: ");
//             double b = double.Parse(Console.ReadLine());
//             Console.Write("Введите сторону c: ");
//             double c = double.Parse(Console.ReadLine());

//             if (a + b > c || b + c > a || c + a > b)
//             {
//                 double p = (a + b + c) / 2;
//                 Console.WriteLine("Это треугольник ");
//             }
//             else
//             {
//                 Console.WriteLine("Это не треугольник");
//             }
            
//         }
//     }
// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// string c = "";

// while (n >= 1)
// {
//    c = (n % 2) + c;
//    n = n / 2;
// }
// Console.Write(c);

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
double Fibonacci(int n)
{
if (n == 1 || n == 2) return 1;
else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < n; i++)
{
Console.Write($"->{Fibonacci(i)}");
}