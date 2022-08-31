// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int num = new Random().Next(10000, 100000);


int a = num % 10;
int b = num / 10000;
int c = num % 100 / 10;
int d = num / 1000 % 10; 

if (a ==b && c==d) Console.WriteLine($"{num}, Да");
else Console.WriteLine($"{num}, Нет");







