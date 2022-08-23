//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
//double result = num / 2;
//if (num == result * 2) Console.Write("Чётное");
//else Console.Write("Нечётное");
if(num % 2 == 0) Console.WriteLine("Чётное");
else Console.WriteLine("Нечётное");
