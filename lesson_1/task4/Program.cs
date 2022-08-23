//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (max < a) max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.Write($"max = {max}");

//if (b < a && a > c)
//{
//    Console.Write(a);
//}
//else if (a < b && b > c)
//{
//    Console.Write(b);
//}
//else
//{
//    Console.Write(c);
//}


