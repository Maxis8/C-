﻿// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше нуля ввёл пользователь.

int MoreZeroNums(int numb)
{ 
    int i = 0;
    int count = 0;
    while( i < numb)
    { 
    Console.WriteLine("Введите число: "); 
    int number = int.Parse(Console.ReadLine());
    i++;
    if(number > 0) count++;
    }
    return count;
}




Console.WriteLine("Введите количество чисел: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел больше нуля: {MoreZeroNums(num)}");
