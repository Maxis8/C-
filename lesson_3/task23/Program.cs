// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов от 1 до N.

Console.WriteLine("Введите число:");
 int num = int.Parse(Console.ReadLine());
 int count =1;
 while(count<=num)
 {
     Console.Write($"{count*count*count} ");
     count++;
 }
 Console.WriteLine();
for(int i=1; i<=num; i++)
Console.Write($"{i*i*i} ");
Console.WriteLine();