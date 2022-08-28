// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число: ");
int days = int.Parse(Console.ReadLine());


  
     if (days > 0 && days < 6 )
     {   
         Console.WriteLine("Нет");
     }
     else if (days > 5 && days < 8) 
     {
        Console.WriteLine("Да");
     }
     else
     {
        Console.WriteLine("Такого дня не существует");
     }
