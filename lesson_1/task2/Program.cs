// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write ($"max = {a}");
}
 else 
{
     Console.Write ($"max = {b}");
}