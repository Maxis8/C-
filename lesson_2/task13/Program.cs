// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int a = num % 1000;
int a1 = a;
a1 = a / 100;
  
     if (a1 == 0)
     {   
         Console.WriteLine($"{num} третьей цифры не существует");
     }
     else 
     {
        Console.WriteLine($"{num}, {a1} ");
     }
